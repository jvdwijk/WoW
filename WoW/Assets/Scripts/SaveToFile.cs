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
        FileStream file;
        if (File.Exists(Application.persistentDataPath + "/" + PlayerPrefs.GetString("Name") + ".txt"))
        {
            file = File.Open(Application.persistentDataPath + "/" + PlayerPrefs.GetString("Name") + ".txt", FileMode.Append);
        }
        else
        {
            file = File.Open(Application.persistentDataPath + "/" + PlayerPrefs.GetString("Name") + ".txt", FileMode.Create);
        }
		

		var data = new NewPlayer ();
		data.playerName = PlayerPrefs.GetString ("Name");
		data.hairType = PlayerPrefs.GetInt("HairType").ToString();
		data.hairColor = PlayerPrefs.GetInt("HairType").ToString();

		bf.Serialize (file, data);
		file.Close ();
	}
}

[Serializable]
class NewPlayer
{
	public string playerName;
	public string hairType;
	public string hairColor;
}