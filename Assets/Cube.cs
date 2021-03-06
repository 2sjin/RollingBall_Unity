using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    private void OnTriggerStay(Collider other) {
        Rigidbody rigid = other.gameObject.GetComponent<Rigidbody>();
        rigid.AddForce(Vector3.up * Time.deltaTime * 15, ForceMode.Impulse);
    }
}