using UnityEngine;
using UnityEngine.SceneManagement; //Scene Manage

public class Pausing : MonoBehaviour
{
    public GameObject Pauseui;
    public GameObject Resumeui;
    public void OnClickPause()   //On click pause button
    {
        Debug.Log("CLICKED");
        Time.timeScale = 0f;    //Slowing  the time
        Resumeui.SetActive(true); //Display Resume menu
        
        Pauseui.SetActive(false); //Hide pause button
        

    }
    public void OnClickResume()         //On clicking Resume button
    {
        Resumeui.SetActive(false);          //Hide Resume menu
        Pauseui.SetActive(true);            //Show pause Button
        Time.timeScale = 1f;                //Returning time to normal
    }
    public void OnClickMenu()               //On clicking Menu button
    {
        Resumeui.SetActive(false);       //Hide Resume menu
        Pauseui.SetActive(true);        //Show pause Button
        Time.timeScale = 1f;            //Returning time to normal
        SceneManager.LoadScene("Menu");     //Switching to Main menu

    }
    
}
