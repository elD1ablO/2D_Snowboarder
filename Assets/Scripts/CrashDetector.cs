using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashParticles;
    [SerializeField] AudioClip crashSound;

    [SerializeField] float crashDelay = 1f;
    bool hasHit = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && !hasHit)
        {
            hasHit = true;
            crashParticles.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
            Invoke("Crashed", crashDelay);
            GetComponent<PlayerController>().DisableControls();
        }
    }

    private void Crashed()
    {
        SceneManager.LoadScene(0);
    }
}
