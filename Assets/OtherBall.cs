using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour {
    MeshRenderer mesh;
    Material mat;

    void Start() {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // 물리적인 충돌 발생 시 이벤트
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Player Ball")
            mat.color = new Color(1, 0, 0);
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.name == "Player Ball")
            mat.color = new Color(0, 0, 0);
    }
}