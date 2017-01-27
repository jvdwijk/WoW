using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollButton : MonoBehaviour
{
    private float ButtonCurrentPosition;
    public Rigidbody rb;
    private Vector3 MoveButtons;

    void Start() {
        rb = GetComponent <Rigidbody>();
        ButtonCurrentPosition = rb.transform.position.y;
        MoveButtons = new Vector3(0, 54, 0);
    }
    void Update()
    {
        ButtonCurrentPosition = rb.transform.position.y;
    }

    public void UpButton()
    {
        rb.transform.position += MoveButtons; 
        Debug.Log(ButtonCurrentPosition);
    }

    public void DownButton()
    {
        rb.transform.position -= MoveButtons;
        Debug.Log(ButtonCurrentPosition);
    }

}
