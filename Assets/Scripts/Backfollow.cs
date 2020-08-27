using UnityEngine;

public class Backfollow : MonoBehaviour
{
    public GameObject plane;
    public Material mat;
    private bool inc;

    private void Awake()
    {
        int backCloudCheck = PlayerPrefs.GetInt("graphics", 1);
        if (backCloudCheck == 0)
        {
            this.gameObject.SetActive(false);
        }
    }

    void FixedUpdate()   //to move the background along with plane
    {
        transform.position = new Vector3(plane.transform.position.x, plane.transform.position.y + 2f, transform.position.z);

    }
}
