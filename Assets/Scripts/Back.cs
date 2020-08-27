using UnityEngine;
using UnityEngine.SceneManagement; //Scene Manage(to change scene)

public class Back : MonoBehaviour
{
    
   public void Backh()     //Back buuton calls this function
    {
        SceneManager.LoadScene("Menu");  // Loading the scene Menu
    }
}
