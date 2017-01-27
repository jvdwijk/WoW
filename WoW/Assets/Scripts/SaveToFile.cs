using System;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class SaveToFile : Save {
	
	public void WriteToFile()
	{
        Debug.Log(PlayerPrefs.GetInt("HairType") + " " + PlayerPrefs.GetInt("HairType"));       
		var data = new NewPlayer ();
		data.playerName = PlayerPrefs.GetString ("Name");
		data.hairType = PlayerPrefs.GetInt("HairType");
		data.hairColor = PlayerPrefs.GetInt("HairColor");

        Saving(data);
	}
}

[Serializable] [XmlRoot("PlayerCollection")]
public class NewPlayer
{
    [XmlAttribute("name")]
    public string playerName;
    [XmlAttribute("hairType")]
	public int hairType;
    [XmlAttribute("hairColor")]
	public int hairColor;
}