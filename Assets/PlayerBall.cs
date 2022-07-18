using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour {
    public float jumpPower;
    bool isJump;
    Rigidbody rigid;

    // 획득한 아이템 수
    public int itemCount;

    void Start() {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
    }

    void Update() {
        // 방향키 이동
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v) * Time.deltaTime * 10, ForceMode.Impulse);

        // 점프
        if(Input.GetButtonDown("Jump") && !isJump) {
            isJump = true;  // 다중 점프 방지
            rigid.AddForce(new Vector3(0, jumpPower, 0) * Time.deltaTime * 10, ForceMode.Impulse);
        }
    }

    // 점프 후 착지 체크
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Floor")
            isJump = false;
    }
}