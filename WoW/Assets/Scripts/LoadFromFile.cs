using System.Collections;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class LoadFromFile : NewPlayer {

    public void Loading(object usedClass)
    {
        var serializer = new XmlSerializer(typeof(NewPlayer));
        using (var stream = new FileStream(Application.persistentDataPath + "/" + "Characters" + ".xml", FileMode.Open))
        {
            return serializer.Deserialize(stream) as NewPlayer;
        }
    }
}
