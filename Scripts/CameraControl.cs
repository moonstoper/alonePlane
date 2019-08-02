using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject plane;
    private Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset.y = transform.position.y - plane.transform.position.y;
      
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = new Vector3(plane.transform.position.x,plane.transform.position.y+2f,transform.position.z);
    }
}
