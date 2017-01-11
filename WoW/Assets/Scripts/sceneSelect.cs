using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class SceneSelect: MonoBehaviour
{
    public void SelectScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("heor");
    }
}
