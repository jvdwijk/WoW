using System;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class SaveToFile : MonoBehaviour {

    private NewPlayer data = new NewPlayer();

    public void WriteToFile()
	{
		data.playerName = PlayerPrefs.GetString ("Name");
		data.hairType = PlayerPrefs.GetInt("HairType");
		data.hairColor = PlayerPrefs.GetInt("HairColor");
        Saving();
	}

    private void Saving()
    {
        var serializer = new XmlSerializer(typeof(NewPlayer));
        var filePath = Application.persistentDataPath + "/" + "Characters" + ".xml";

        FileMode currentFileMode = (File.Exists(filePath)) ? FileMode.Append : FileMode.Create;

        FileStream fileStream = File.Open(Application.persistentDataPath + "/" + "Characters" + ".xml", currentFileMode);

        serializer.Serialize(fileStream, data);
        fileStream.Close();
    }
}

//[Serialable]
[XmlRoot("PlayerCollection")]
public class NewPlayer : MonoBehaviour
{

    [XmlAttribute("name")]
    public string playerName;
    [XmlAttribute("hairType")]
    public int hairType;
    [XmlAttribute("hairColor")]
    public int hairColor;
}