using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressReset : MonoBehaviour
{
    public void ResetProgress()
    {
        AudioPlayer.instance.ResetButtonSound();
        PlayerPrefs.DeleteAll();
    }
}
