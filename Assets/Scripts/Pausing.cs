using UnityEngine;
using UnityEngine.SceneManagement; //Scene Manage
using System.Collections;
using TMPro;

public class Pausing : MonoBehaviour
{
    public GameObject Pauseui;
    public GameObject Resumeui;
    public int countdownTime;

    public GameObject OnCollideMenu;
    public GameObject CountdownUi;
    int timer = 0;
    public GameObject tutorial;

    private void Awake()
    {   Pauseui.SetActive(false);
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Time.timeScale = 0f;
        player.GetComponent<PlaneMovement>().enabled = false;
        CountdownUi.SetActive(true);
        
        StartCoroutine(Countdown());
    }

    public void OnClickPause()   //On click pause button
    {

        Time.timeScale = 0f;    //Slowing  the time
        Resumeui.SetActive(true); //Display Resume menu
        FindObjectOfType<PlaneMovement>().enabled = false;
        FindObjectOfType<AudioManager>().PlayAudio(2);
        Pauseui.SetActive(false); //Hide pause button


    }
    public void OnClickResume()         //On clicking Resume button
    {
        Resumeui.SetActive(false);          //Hide Resume menu
        Pauseui.SetActive(true);            //Show pause Button
        CountdownUi.SetActive(true);
        FindObjectOfType<AudioManager>().PlayAudio(2);
        StartCoroutine(Countdown());



    }
    public void OnClickMenu()               //On clicking Menu button
    {   FindObjectOfType<AudioManager>().PlayAudio(2);
        Resumeui.SetActive(false);       //Hide Resume menu
        Pauseui.SetActive(true);        //Show pause Button
        Time.timeScale = 1f;            //Returning time to normal
        SceneManager.LoadScene("Menu");     //Switching to Main menu

    }

    IEnumerator Countdown()
    {
        timer = countdownTime;

        while (timer >= 0)
        {
            //CountdownUi.text = timer.ToString();
            if (timer != 0)
                {CountdownUi.GetComponent<TextMeshProUGUI>().text = timer.ToString();}
            else
                {CountdownUi.GetComponent<TextMeshProUGUI>().text = "GO";
                }
                FindObjectOfType<AudioManager>().PlayAudio(3);
            timer--;
            yield return new WaitForSecondsRealtime(1);

        }
        Time.timeScale = 1f; //Returning time to normal
        FindObjectOfType<PlaneMovement>().enabled = true;
        CountdownUi.SetActive(false);
        tutorial.SetActive(false);
        Pauseui.SetActive(true);
        yield return null;


    }

    public void OnDeath()
    {   
        Time.timeScale = 0.0f;

        OnCollideMenu.SetActive(true);
        //FindObjectOfType<PlaneMovement>().enabled = false;
        
        FindObjectOfType<ScoreManager>().OndeathScore();
    }

    public void Restart()   //if restart is selected
    {
        SceneManager.LoadScene("PlayScene");
        Time.timeScale = 1f;
    }

}
