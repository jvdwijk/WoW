using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollButton : MonoBehaviour
{

    float buttonPosition;

    void Start() {
        buttonPosition = GameObject.Find("Content").transform.position.y;
        Debug.Log(buttonPosition);
                }
    void Update()
    {
        buttonPosition = GameObject.Find("Content").transform.position.y;
    }

    public void UpButton()
    {
        buttonPosition += 10;
        Debug.Log(buttonPosition);
    }

}
