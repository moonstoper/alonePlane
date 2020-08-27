using System.Collections;
using UnityEngine;

public class SpecialSpwaner : MonoBehaviour
{
    public GameObject[] enemies;
    Vector2 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    int randEnemy;
    
    public GameObject instant;
    // int rClone;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitSpawner());  //For creting IEnumerator function

    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);    //Waiting for desired seconds
        while (!stop)                                 //conidtion will always run
        {
            spawnValues = Camera.main.transform.position;    //Getting position of camera
            randEnemy = Random.Range(0, enemies.Length);                  //getting enemies index
            //modify below line for spawn position
            Vector3 spawnPosition = new Vector3(Random.Range(spawnValues.x - 3, spawnValues.x + 3), Random.Range(spawnValues.y + 12, spawnValues.y + 15), 0f);  //determing the postion for generating
            Destroy(Instantiate(enemies[randEnemy], spawnPosition + transform.transform.TransformPoint(0, 0, 0), gameObject.transform.rotation),6);

           


            yield return new WaitForSeconds(startWait);
        }

    }
}
