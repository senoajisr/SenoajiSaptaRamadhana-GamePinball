using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider ball;

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Ball hits Bumper!");
    }
}
