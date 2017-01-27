using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class Save : MonoBehaviour {

    public void Saving(object usedClass)
    {
        var serializer = new XmlSerializer(typeof(NewPlayer));
        var filePath = Application.persistentDataPath + "/" + "Characters" + ".xml";

        FileMode currentFileMode = (File.Exists(filePath)) ? FileMode.Append : FileMode.Create;

        FileStream fileStream = File.Open(Application.persistentDataPath + "/" + "Characters" + ".xml", currentFileMode);

        serializer.Serialize(fileStream, usedClass);
        fileStream.Close();
    }
}
