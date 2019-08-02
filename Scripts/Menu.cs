using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void About()
    {
       
        SceneManager.LoadScene("About");
    }
    public void QuitApp()
    {
        
        Debug.Log("Quiting.............");
        Application.Quit();
    }
}
