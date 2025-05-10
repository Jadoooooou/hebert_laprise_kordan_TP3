using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_jeu : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene("Niveau1");
    }

    public void quitterPartie()
    {
        Application.Quit();
    }


    /*
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("zone1"))
    {
        ampoule.SetActive(true);
    }
    else if (other.CompareTag("zone3"))
    {
        videoPlayer.Play();
    }
    else if (other.CompareTag("zone2"))
    {
        animLumiere.Play("fadeIn");
    }
    else if (other.CompareTag("etoile"))
    {
        other.gameObject.SetActive(false);
        count++;
        pointage.OnChangerPointage(count);
    }
}
void OnTriggerExit(Collider other)
{
    if (other.CompareTag("zone1"))
    {
        ampoule.SetActive(false);
    }
    else if (other.CompareTag("zone3"))
    {
        videoPlayer.Stop();
    }
    else if (other.CompareTag("zone2"))
    {
        animLumiere.Play("fadeOut");
    }
}
*/
}