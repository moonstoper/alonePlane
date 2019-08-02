using UnityEngine;

public class Backfollow : MonoBehaviour
{ 
    public GameObject plane;
    

    
    void FixedUpdate()   //to move the background along with plane
    {
        transform.position = new Vector3(transform.position.x,plane.transform.position.y + 2f, transform.position.z);
        if (transform.rotation.z < 180) //adding rotation
        {
            transform.Rotate(0, 0, transform.rotation.z+0.001f);

        }
        else
            transform.Rotate(0, 0, transform.rotation.z+0.001f);
        

    }
}
