using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NameGenerator : MonoBehaviour {
	[SerializeField]
	private string[] names;
	[SerializeField]
	private Text nameSpace;

	public void ChangeName()
	{
		var tempNumber = Random.Range (0, names.Length);

		for (int i = 0; i < names.Length; i++) {
			if (tempNumber == i){
				PlayerPrefs.SetString ("Name",names[i]);
				nameSpace.text = names [i];
			}
		}
	}
}
