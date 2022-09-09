using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float restartLevelDelay = .5f;
    [SerializeField] float loadNextLevelDelay = 1f;

    [SerializeField] float loadLevelSelectionDelay = 1f;
    
    public void RestatLevel()
    {
        StartCoroutine(DelayedLevelReload());
    }
    IEnumerator DelayedLevelReload()
    {
        yield return new WaitForSeconds(restartLevelDelay);
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    
    public void LoadNextLevel()
    {
        AudioPlayer.instance.PlayButtonSound();
        StartCoroutine(DelayedLoadNextLevel());
    }
    IEnumerator DelayedLoadNextLevel()
    {
        yield return new WaitForSeconds(loadNextLevelDelay);
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = ++currentSceneIndex;

        if(nextSceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }

        SceneManager.LoadScene(nextSceneIndex);
    }

    public void LoadLevelSelection()
    {
        StartCoroutine(LoadLevelSelectionDelayed());
    }
    IEnumerator LoadLevelSelectionDelayed()
    {
        yield return new WaitForSeconds(loadLevelSelectionDelay);
        SceneManager.LoadScene("Level Selection");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
