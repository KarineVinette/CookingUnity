using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Annonce;
    public GameObject Title;
    

    public void PlayGame()
    {
        //SceneManager.LoadScene("CookingMe");
        StartCoroutine(Transition());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator Transition()

    {
        Title.SetActive(false);
        Annonce.SetActive(true);
        yield return new WaitForSeconds(3);
        Annonce.SetActive(false);
        SceneManager.LoadScene("CookingMe");
       
    }
}
