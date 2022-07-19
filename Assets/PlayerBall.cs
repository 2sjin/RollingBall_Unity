using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour {
    public float jumpPower;
    bool isJump;
    Rigidbody rigid;
    public GameManagerLogic manager;
    public int itemCount;   // 획득한 아이템 수

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

        // 추락 시 재시작
        if (transform.position.y < -3)
            SceneManager.LoadScene("Stage" + manager.stage);

    }

    // 점프 후 착지 체크
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Floor")
            isJump = false;
    }
    
}