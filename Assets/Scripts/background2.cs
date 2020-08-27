using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background2 : MonoBehaviour
{
    // Start is called before the first frame update
    Transform player;
    public Transform pointCamera;

    int graphhic;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //pointCamera = null;
        pointCamera = GetComponentInChildren<AudioManager>().transform;



    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position = new Vector3(player.position.x, player.position.y, 1);
        transform.Rotate(0, 0, .05f);



    }
}
