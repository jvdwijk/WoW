using System;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class SaveToFile : NewPlayer {

    [SerializeField]
    private Save save;

	public void WriteToFile()
	{
		var data = new NewPlayer ();
		data.playerName = PlayerPrefs.GetString ("Name");
		data.hairType = PlayerPrefs.GetInt("HairType");
		data.hairColor = PlayerPrefs.GetInt("HairColor");
        Debug.Log("test");
        save.Saving(data);
	}
}