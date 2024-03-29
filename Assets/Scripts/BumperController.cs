using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider ball;
    public float multiplier;
    public Renderer anotherRenderer;
    public Animator animator;
    public AudioSource audioSource;
    public ParticleSystem particles;
    public float score;
    public ScoreManager scoreManager;

    private void Start() {
        particles.Stop();
    }

    private void OnCollisionEnter(Collision collision) {
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        ballRigidbody.velocity *= multiplier;
        animator.SetTrigger("Hit");
        
        audioSource.transform.position = collision.transform.position;
        audioSource.Play();

        particles.Play();

        scoreManager.AddScore(score);
    }
}
