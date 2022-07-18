using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCapsule : MonoBehaviour {
    public float rotateSpeed;

    void Update() {
        // 아이템 회전 효과(월드 좌표계 기준)
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            PlayerBall player = other.GetComponent<PlayerBall>();
            player.itemCount++;

            ItemSound.sound.Play();

            gameObject.SetActive(false);
        }
    }
}