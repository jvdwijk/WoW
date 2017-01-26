using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

using System.Xml;
using System.Xml.Serialization;

public class SaveToFile : MonoBehaviour {
	
	public void WriteToFile()
	{
        Debug.Log(PlayerPrefs.GetInt("HairType") + " " + PlayerPrefs.GetInt("HairType"));
        //var bf = new BinaryFormatter();
        
		var data = new NewPlayer ();
		data.playerName = PlayerPrefs.GetString ("Name");
		data.hairType = PlayerPrefs.GetInt("HairType");
		data.hairColor = PlayerPrefs.GetInt("HairColor");

        data.Save();
	}
}

[Serializable] [XmlRoot("PlayerCollection")]
public class NewPlayer
{
   // [XmlArray("Players")[XmlArrayItem("Player")]
    [XmlAttribute("name")]
    public string playerName;
    [XmlAttribute("hairType")]
	public int hairType;
    [XmlAttribute("hairColor")]
	public int hairColor;

    public void Save()
    {
        var serializer = new XmlSerializer(typeof(NewPlayer));
        FileStream fileStream;
        if (File.Exists(Application.persistentDataPath + "/" + "Characters" + ".xml"))
        {
            fileStream = File.Open(Application.persistentDataPath + "/" + "Characters" + ".xml", FileMode.Append);
        }
        else
        {
            fileStream = File.Open(Application.persistentDataPath + "/" + "Characters" + ".xml", FileMode.Create);
        }
        serializer.Serialize(fileStream, this);
        fileStream.Close();
    }
}