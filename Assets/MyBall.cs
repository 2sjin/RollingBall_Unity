using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyBall : MonoBehaviour {
    Rigidbody rigid;

    void Start() {
        rigid = GetComponent<Rigidbody>();

    }

    void Update() {
        // 점프
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
        }

        // 방향 이동
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec * Time.deltaTime * 50, ForceMode.Impulse);

        // 추락 판정(게임 재시작)
        if (transform.position.y < -2)
            SceneManager.LoadScene("SampleScene");
    }
}
