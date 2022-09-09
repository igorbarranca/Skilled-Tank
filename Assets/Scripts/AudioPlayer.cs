using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Button Sounds")]
    [SerializeField] AudioClip playBtnSFX;
    [SerializeField] [Range(0f, 1f)] float playBtnVolume = .5f;
    [SerializeField] AudioClip creditsBtnSFX;
    [SerializeField] [Range(0f, 1f)] float creditsBtnVolume = .5f;
    [SerializeField] AudioClip resetBtnSFX;
    [SerializeField] [Range(0f, 1f)] float resetBtnVolume = .5f;
    [Header("Player Sounds")]
    [SerializeField] AudioClip crashSFX;
    [SerializeField] [Range(0f, 1f)] float crashVolume = .5f;
    [Header("Level Sounds")]
    [SerializeField] AudioClip finishLineSFX;
    [SerializeField] [Range(0f, 1f)] float finishLineVolume = .5f;

    public static AudioPlayer instance;

    private void Awake()
    {
        ManageSingleton();
    }

    public void PlayButtonSound()
    {
        PlayClip(playBtnSFX, playBtnVolume);
    }
    public void CreditsButtonSound()
    {
        PlayClip(creditsBtnSFX, creditsBtnVolume);
    }
    public void ResetButtonSound()
    {
        PlayClip(resetBtnSFX, resetBtnVolume);
    }
    public void CrashSound()
    {
        PlayClip(crashSFX, crashVolume);
    }
    public void FinishLineSound()
    {
        PlayClip(finishLineSFX, finishLineVolume);
    }

    void PlayClip(AudioClip clip, float volume)
    {
        if(clip != null)
        {
            Vector2 cameraPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPos, volume);
        }
    }

    void ManageSingleton()
    {
        if(instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
