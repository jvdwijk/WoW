using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSaving : MonoBehaviour {

	void Start () {
		if (!PlayerPrefs.HasKey ("HairType")) 
		{
			PlayerPrefs.SetInt ("HairType",1);
		}
		if(!PlayerPrefs.HasKey ("HairColor"))
		{
			PlayerPrefs.SetInt ("HairColor",1);
		}
	}

	public void SetHairType(int key)
	{
		PlayerPrefs.SetInt ("HairType",key);
	}
	public void SetHairColor(int colorKey)
	{
		PlayerPrefs.SetInt ("HairColor",colorKey);
	}
}
