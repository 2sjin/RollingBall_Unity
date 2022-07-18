using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSound : MonoBehaviour {
    public static AudioSource sound;

    void Start() {
        sound = GetComponent<AudioSource>();
    }
}