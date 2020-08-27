using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterPickup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] qoutes;
    
    public void QoutesInst(Transform location)
    {   FindObjectOfType<AudioManager>().PlayAudio(0);
        Destroy(Instantiate(qoutes[Random.Range(0,qoutes.Length)],location.position,Quaternion.identity),2);
    }
}
