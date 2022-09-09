using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] LevelLoader levelLoader;
    [SerializeField] int levelToUnlock;
    [SerializeField] GameObject levelCompletedText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();
        if(player == null) { return; }

        levelCompletedText.SetActive(true);
        AudioPlayer.instance.FinishLineSound();

        PlayerPrefs.SetInt("levelReached", levelToUnlock);

        levelLoader.LoadLevelSelection();
    }
}
