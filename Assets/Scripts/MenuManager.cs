using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("City");
    }

    public void QuitGame()
    {
        Debug.Log ("Quit!");
        Application.Quit();
    }
        public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Back()
    {
        Debug.Log("BACK");
        SceneManager.LoadScene("Menu");
    }
}