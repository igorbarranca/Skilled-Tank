using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] LevelLoader levelLoader;
    [SerializeField] ParticleSystem crashParticle;
    [SerializeField] GameObject crashText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            crashText.SetActive(true);

            AudioPlayer.instance.CrashSound();
            crashParticle.Play();

            levelLoader.RestatLevel();
        }
    }
}
