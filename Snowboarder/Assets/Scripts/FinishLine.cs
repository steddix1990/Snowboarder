using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float levelDelay = 1f;
    [SerializeField] ParticleSystem finishParticle;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishParticle.Play();
            Invoke("ReloadScene", levelDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}