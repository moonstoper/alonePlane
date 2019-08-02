using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaing2 : MonoBehaviour
{
    public GameObject[] enemies;
    Vector2 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    int randEnemy;
    public GameObject totarget;
    public GameObject instant;
    // int rClone;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitSpawner());

    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {// rClone = Random.Range(1, 2);
            spawnValues = Camera.main.transform.position;
            randEnemy = Random.Range(0, 2);
            //modify below linne for spawn position
            Vector3 spawnPosition = new Vector3(Random.Range(spawnValues.x - 3, spawnValues.x + 3), Random.Range(spawnValues.y + 12, spawnValues.y + 15), 1f);
            GameObject instant = Instantiate(enemies[randEnemy], spawnPosition + transform.transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            Destroy(instant, 10);


            yield return new WaitForSeconds(startWait);
        }

    }
}
