using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour
{
    [SerializeField]
    private float horizontalSpeed;
    [SerializeField]
    private float turnSpeed;
    private bool _rotate;
    private bool lrotate;

    void Update()
    {
        if (lrotate)
        {
            transform.Rotate(new Vector3(0, 5, 0));

        }
        if (_rotate)
        {
            transform.Rotate(new Vector3(0, -5, 0));
        }
        if (Input.GetMouseButton(0))
        {
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            transform.Rotate(0, -h, 0);
        }
    }
         public void OnPress()
    {
        _rotate = true;
    }

    public void OnRelease()
    {
        _rotate = false;
    }
    public void lOnPress()
    {
        lrotate = true;
    }

    public void lOnRelease()
    {
        lrotate = false;
    }


}



