using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public float score;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    private Renderer rendererBumper;
    private Animator animatorBumper;

    private void Start()
    {
        rendererBumper = GetComponent<Renderer>();
        animatorBumper = GetComponent<Animator>();
    }
    
    // Start is called before the first frame update
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            // animation
            animatorBumper.SetTrigger("hit");

            // play sfx
            audioManager.PlaySFX_Bumper(collision.transform.position);

            //play vfx
            vfxManager.PlayVFX_Bumper(collision.transform.position);

            //add score
            scoreManager.AddScore(score);
        }
    }
}