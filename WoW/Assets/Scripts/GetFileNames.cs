using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GetFileNames : MonoBehaviour {

    private string[] names;

    void Awake () {
		foreach(string file in Directory.GetFiles(Application.persistentDataPath, "*.txt"))
        {
            var name = file.ToString();
            Debug.Log(file.ToString());
        }
	}
}
