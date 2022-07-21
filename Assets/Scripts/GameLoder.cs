using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoder : MonoBehaviour
{
    public void LoadGame(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));

    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log (operation);

            yield return null;
        }
    }
}
