using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject loadingScreem;
    public GameObject settingscreen;
    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().PlayAudio(2);
        loadingScreem.SetActive(true);
        FindObjectOfType<loadscreen>().loadscene();
    }
    public void About()
    {
        FindObjectOfType<AudioManager>().PlayAudio(2);

        SceneManager.LoadScene("About");
    }
    public void QuitApp()
    {

        Debug.Log("Quiting.............");
        Application.Quit();
    }

    public void Settings()
    {
        settingscreen.SetActive(true);
        FindObjectOfType<SettingMenu>().OnSettingActive();
    }
}
