using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoad: MonoBehaviour
{
    public void SelectScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
