using UnityEngine;
using System.Collections;

public class camera_switch : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
  
     void Start()
    {
        Camera1.enabled = true;
        Camera2.enabled = false;
   }

    void FixedUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (!Camera2.enabled)
            {
                Camera1.enabled = false;
                Camera2.enabled = true;
            }
         
         }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Camera1.enabled = true;
            Camera2.enabled = false;
        }
    }

}
