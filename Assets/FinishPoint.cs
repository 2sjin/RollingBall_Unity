using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour {
    public GameManagerLogic manager;

    private void OnTriggerEnter(Collider other) {
        // 플레이어와 접촉 시
        if (other.tag == "Player") {
            // 아이템 다 먹으면 다음 씬으로 이동
            if (other.GetComponent<PlayerBall>().itemCount == manager.totalItemCount) {
                manager.stage++;
                SceneManager.LoadScene("Stage" + manager.stage);
            }
        }
    }

}