using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Collider ball;

    private void OnTriggerEnter(Collider other) {
        if (other == ball) {
            Debug.Log("Ball hit the switch");
        }
    }
}
