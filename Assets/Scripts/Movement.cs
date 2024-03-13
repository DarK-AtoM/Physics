using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 10;
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3 (0,0,1) *Time.deltaTime * speed);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag=="Finish")
        {
            speed = 0;
        }
        else if (other.tag=="Checkpoint")
        {
            speed = 20;
        }
                 
    }
}
