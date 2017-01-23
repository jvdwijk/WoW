using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFileNames : MonoBehaviour {

	void Awake () {
		foreach(string file in System.IO.Directory.GetFiles(Application.persistentDataPath))
        {
        }
	}
}
