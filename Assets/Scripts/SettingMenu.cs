using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SettingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] gameObjects;
    public AudioMixer audioMixer;
    public Toggle toggle;
    public Slider slider;
    public void OnSettingActive()
    {
        foreach (GameObject item in gameObjects)
        {
            item.SetActive(false);
        }
        int graphic = PlayerPrefs.GetInt("graphics", 1);
        if (graphic == 1)
            toggle.isOn = true;
        else toggle.isOn = false;

        float volume = PlayerPrefs.GetFloat("volume", 1);
        slider.value = volume;

    }

    public void OnSettingClose()
    {
        foreach (GameObject item in gameObjects)
        {
            item.SetActive(true);
        }
        this.gameObject.SetActive(false);
    }

    public void Setvolume(float volume)
    {

        audioMixer.SetFloat("Volume", volume);
        PlayerPrefs.SetFloat("volume", volume);
    }

    public void SetGraphic(bool value)
    {
        if (value)
        {
            PlayerPrefs.SetInt("graphics", 1);
        }
        else PlayerPrefs.SetInt("graphics", 0);
    }
}
