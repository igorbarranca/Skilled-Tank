using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsButton : MonoBehaviour
{
    [SerializeField] GameObject creditsText;

    public void ActivateCreditsText()
    {
        AudioPlayer.instance.CreditsButtonSound();
        creditsText.SetActive(true);
    }
}
