using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] float loadDelay = 1f;
    
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {            
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("Finished", loadDelay);
            
        }        
    }

    private void Finished()
    {
        SceneManager.LoadScene(0);
    }
}
