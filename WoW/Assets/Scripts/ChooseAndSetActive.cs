using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseAndSetActive : MonoBehaviour
{

    [SerializeField]
	private GameObject[] mainAsset; //always put in the main asset first!

    void Awake()
    {
		for (int i = 0; i < mainAsset.Length; i++)
        {
			//mainAsset[i] = mainAsset[i].GetComponent<GameObject>();
			if(mainAsset[i] != mainAsset[0]) 
            {
				mainAsset[i].SetActive (false);
            }
            else
            {
				mainAsset[i].SetActive (true);
            }
        }
    }

	public void HairUpdate(GameObject active)
    {
		for (int i = 0; i < mainAsset.Length; i++)
        {
			if (mainAsset[i].name == active.name)
            {
				mainAsset[i].SetActive (true);
            }
            else
            {
				mainAsset[i].SetActive (false);
            }
        }       
    }
}
