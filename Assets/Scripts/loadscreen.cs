using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;
public class loadscreen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Gtodisable;
    public TextMeshProUGUI hintstext;
    public string[] hints;
    public void loadscene()
    {
        foreach (GameObject gb in Gtodisable)
        {
            gb.SetActive(false);
        }
        this.GetComponent<SpriteRenderer>().enabled = true;
        StartCoroutine(loadSceneAsync());
        hintstext.text = hints[Random.Range(0,hints.Length)];

    }

    IEnumerator loadSceneAsync()
    {
        AsyncOperation AO = SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(1);
       
        while(AO.progress <.9f)
        {
           // Debug.Log(AO.progress * 100+"%");
            yield return null;
            
        }
        SceneManager.LoadScene(1);
        this.gameObject.SetActive(false);
        
    }
}
