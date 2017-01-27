using UnityEngine;
using System.Collections;

public class dg : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    public void ShowOverheadView()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            firstPersonCamera.enabled = false;
            overheadCamera.enabled = true;
        }
        
    }

    public void ShowFirstPersonView()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            firstPersonCamera.enabled = true;
            overheadCamera.enabled = false;
        }
    }
}
