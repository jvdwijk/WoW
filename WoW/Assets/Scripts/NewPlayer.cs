using System;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;


[Serializable]
[XmlRoot("PlayerCollection")]
public class NewPlayer : MonoBehaviour {

        [XmlAttribute("name")]
        public string playerName;
        [XmlAttribute("hairType")]
        public int hairType;
        [XmlAttribute("hairColor")]
        public int hairColor;
    }

