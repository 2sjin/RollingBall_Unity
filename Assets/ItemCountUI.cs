using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCountUI : MonoBehaviour {
    public GameManagerLogic manager;
    public PlayerBall player;

    void Update() {
        GetComponent<Text>().text = player.itemCount + " / " + manager.totalItemCount;
    }
}
