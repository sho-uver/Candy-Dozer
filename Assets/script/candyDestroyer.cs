using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyDestroyer : MonoBehaviour {
    public candyManager candyManager;
    public int reward;
    void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Candy") {
            candyManager.AddCandy (reward);
            Destroy (other.gameObject);
        }
    }
}