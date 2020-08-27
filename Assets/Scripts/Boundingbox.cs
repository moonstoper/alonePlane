using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundingbox : MonoBehaviour
{
    

    // Update is called once per frame
    void FixedUpdate()
    {
        //moving boundries vertical along with camera but fixing the horizontal
        transform.position = new Vector3(transform.position.x, Camera.main.transform.position.y, transform.position.z);     
    }
}
