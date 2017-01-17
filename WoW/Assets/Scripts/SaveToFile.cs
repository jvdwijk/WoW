using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class SaveToFile : MonoBehaviour {
	
	public void WriteToFile()
	{
		var bf = new BinaryFormatter();
		FileStream file = File.Open (Application.persistentDataPath + "/SaveFile.dat", FileMode.OpenOrCreate);

		var data = new NewPlayer ();
		data.playerName = PlayerPrefs.GetString ("Name");
		data.hairType = PlayerPrefs.GetInt ("HairType");
		data.hairColor = PlayerPrefs.GetInt ("HairType");

		bf.Serialize (file, data);
		file.Close ();
	}
}

[Serializable]
class NewPlayer
{
	public string playerName;
	public int hairType;
	public int hairColor;
}