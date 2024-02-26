using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider ball;
    public float multiplier;

    private void OnCollisionEnter(Collision collision) {
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        ballRigidbody.velocity *= multiplier;
    }
}
