using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour
{
    private float horizontalSpeed = 2.0F;
   
    public float turnSpeed = 200f;
    
   
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            transform.Rotate(0, -h, 0);
        }

    }
    public void RotateRight()
    {
        transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    }
    public void RotateLeft()
    {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
    
}