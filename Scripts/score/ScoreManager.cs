using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    
    public TextMeshProUGUI score;
    public TextMeshProUGUI hscore;
    public GameObject checkpausepanel;
    public GameObject failedpaned;
    int instant = 0;


    private void Start()
    {
        hscore.text = PlayerPrefs.GetInt("HighScore",0).ToString();   //Creating score file or getting high score from prebuid file
        
    }

    private void FixedUpdate()
    {
        if (checkpausepanel.activeSelf == true || failedpaned.activeSelf==true) //For checking if Pause menu or Restart menu is active
        {

            score.text = instant.ToString();                 //Holding the Current score 
        }
        else
        {
             instant = (int)Time.timeSinceLevelLoad / 2;   //increasing the Current score
            score.text = instant.ToString();
            if (instant > PlayerPrefs.GetInt("HighScore", 0))     //to change High Score if Current score becomes greater
            {
                PlayerPrefs.SetInt("HighScore", instant);
                hscore.text = instant.ToString();
            }
        }
    }
}
