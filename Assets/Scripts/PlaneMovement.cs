using UnityEngine;
//using UnityEngine.SceneManagement;
using System.Collections;

public class PlaneMovement : MonoBehaviour
{
   [SerializeField] public float moveSpeed = 5f;
    [SerializeField] float angularSpeed = 3f;
    float rotationX;
    public Rigidbody2D rb;
    float movePlaneY;
    public GameObject Warningleft;
    public GameObject WarningRight;
    public GameObject explosion;
    
   
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))  // if screen pressed
        {
            float pos = Input.GetAxis("Mouse X");  //horizontal mouse postion assign to pos
            
           
               // transform.Rotate(0, 0, -(pos * angularSpeed));


            //Rotating the plane
            if(pos<0)
            {   
                transform.Rotate(0, 0, (3 * angularSpeed));    
            }
            else
                if(pos>0)
                    {
                      transform.Rotate(0, 0,-(3 * angularSpeed));
            }
        }



        //line to edit:::::::::::::::

    }
    

    
    private void FixedUpdate()
    {   
        rb.velocity = transform.up * moveSpeed*(1F+Time.deltaTime);     //MOving plane continously to direction it is facing


        //Showing warning if getting to close to boundary
        //Also slowing the plane
        // if (transform.position.x < -12f || transform.position.x>12f)    
        // {
        //     Time.timeScale = 0.3f;
        //     if (transform.position.x < -12f)
        //         Warningleft.SetActive(true);
        //     else
        //         WarningRight.SetActive(true);


        // }
        // else
        // {
        //     Time.timeScale = 1f;
        //     Warningleft.SetActive(false);
        //     WarningRight.SetActive(false);
        // }


            
       
        

       
    }
    public void OnTriggerEnter2D(Collider2D collision)  //if collision occur
    {
       
        if(collision.CompareTag("Enemy"))
        {   FindObjectOfType<AudioManager>().PlayAudio(1);
            Destroy(Instantiate(explosion,transform.position,Quaternion.identity),3);
            StartCoroutine(waitbeforePause());
           // FindObjectOfType<Pausing>().OnDeath();  
            
        }  
        if(collision.CompareTag("BoundL"))
        {
                Time.timeScale = .3f;
                Warningleft.SetActive(true);
            
        }
        if(collision.CompareTag("Bound"))
        {   Time.timeScale = .3f;
            WarningRight.SetActive(true);
        }

        if(collision.CompareTag("Save"))
        {
            FindObjectOfType<ScoreManager>().BonusSave();
            FindObjectOfType<AfterPickup>().QoutesInst(collision.transform);
            Destroy(collision.gameObject);
            
        }
        

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Bound") || other.gameObject.CompareTag("BoundL"))
        {   FindObjectOfType<AudioManager>().PlayAudio(1);
            Destroy(Instantiate(explosion,transform.position,Quaternion.identity),3);
            StartCoroutine(waitbeforePause());
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        
            Time.timeScale = 1f;
            Warningleft.SetActive(false);
            WarningRight.SetActive(false);
    }
   
   IEnumerator waitbeforePause()
   {   
       yield return new WaitForSeconds(.2f);
       Destroy(gameObject);
       FindObjectOfType<Pausing>().OnDeath();
   }
    
   
}
