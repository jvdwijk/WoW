using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInformation : MonoBehaviour {

	[SerializeField]
	private int hairType;
	private PickColor chosenColor;

	void Start () {
		chosenColor = GetComponent<PickColor> ();
		if (hairType == PlayerPrefs.GetInt ("HairType")) 
		{
			gameObject.SetActive (true);
			Debug.Log ("true" + PlayerPrefs.GetInt ("HairType"));
		} 
		else 
		{
			gameObject.SetActive (false);
			Debug.Log ("false" + hairType);
		}
		chosenColor.PutColor (PlayerPrefs.GetInt ("HairColor"));
	}
}
