using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class sceneSelect: MonoBehaviour
{
    public void SceneSelect(int scene)
    {

        SceneManager.LoadScene(scene);

    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("heor");
    }

    void Start()
    {

    }


    void Update()
    {

    }
}
