using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderButton : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] int levelToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    IEnumerator LoadSceneDelayed()
    {
        yield return new WaitForSeconds(loadDelay);
        SceneManager.LoadScene(levelToLoad);
    }
}
