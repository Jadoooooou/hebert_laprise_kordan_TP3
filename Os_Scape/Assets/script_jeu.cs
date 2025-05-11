using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_jeu : MonoBehaviour
{
    public GameObject porteGauche;
    public GameObject porteDroite;

    public AudioSource myAudioSource;

    public GameObject[] vies;
    public int decompteVies;

    public void jouer()
    {
        SceneManager.LoadScene("Niveau1");
    }
    public void quitterPartie()
    {
        Application.Quit();
    }

    void Start()
    {
        decompteVies = 3;
    }

    void PerteVies(Collider other)
    {
        if (other.CompareTag("???"))
        {
            decompteVies -= 1;
            vies[decompteVies].SetActive(false);
        }
        if (decompteVies == 0)
        {
            //recommencer niveau1
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("h1porteGauche"))
        {
            porteGauche.SetActive(false);
            porteDroite.SetActive(true);
        }
        else if (other.CompareTag("h1porteDroite"))
        {
            porteDroite.SetActive(false);
            porteGauche.SetActive(true);
        }
    }

    public void VolumeOn() 
    {
        myAudioSource.Play();
    }

    public void VolumeOff()
    {
        myAudioSource.Stop();
    }
}

