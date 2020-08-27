using UnityEngine;
using UnityEngine.Audio;
public class MusicManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] music;
    public GameObject player;
    public AudioSource audioSource;
    public AudioMixer audioMixer;
    void Start()
    {
        audioSource.loop = true;
        audioSource.clip = music[Random.Range(0, music.Length)];
        audioSource.volume = PlayerPrefs.GetFloat("volume", 1);
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            audioSource.Pause();
    }

}
