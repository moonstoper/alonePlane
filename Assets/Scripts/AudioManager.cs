using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip pickup;
    public AudioClip hit;
    public AudioClip select;
    public AudioClip countdown;
    public AudioSource audioSource;
    public AudioClip[] music;

    private void Start()
    {
        audioSource.volume = PlayerPrefs.GetFloat("volume", 1);
    }

    public void PlayAudio(int index)
    {
        switch (index)
        {
            case 0:
                audioSource.PlayOneShot(pickup);
                break;
            case 1:
                audioSource.PlayOneShot(hit);
                break;

            case 2:
                audioSource.PlayOneShot(select);
                break;

            case 3:
                audioSource.PlayOneShot(countdown);
                break;
            default: break;
        }
    }


}
