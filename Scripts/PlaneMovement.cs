using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneMovement : MonoBehaviour
{
   [SerializeField] public float moveSpeed = 5f;
    [SerializeField] float angularSpeed = 3f;
    float rotationX;
    public Rigidbody2D rb;
    float movePlaneY;
    public GameObject OnCollideMenu;
    public GameObject Warningleft;
    public GameObject WarningRight;
    
   
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
        if (transform.position.x < -12f || transform.position.x>12f)    
        {
            Time.timeScale = 0.3f;
            if (transform.position.x < -12f)
                Warningleft.SetActive(true);
            else
                WarningRight.SetActive(true);


        }
        else
        {
            Time.timeScale = 1f;
            Warningleft.SetActive(false);
            WarningRight.SetActive(false);
        }


            
       
        

       
    }
    public void OnCollisionEnter2D(Collision2D collision)  //if collision occur
    {
       

        
        Pause();      
        

    }
    public void Pause()     //pausing the game and showing the failed menu
    {
        Time.timeScale = 0.0f;
        OnCollideMenu.SetActive(true);
        
        
        
    }
    public void Restart()   //if restart is selected
    {  
        SceneManager.LoadScene("PlayScene");
        Time.timeScale = 1f;
    }
    public void Menu()  //if menu is selected

    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
