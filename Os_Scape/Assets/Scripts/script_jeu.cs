using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_jeu : MonoBehaviour
{

    public GameObject[] vies;
    public int decompteVies;

    public GameObject defaite;

    public void jouer()
    {
        SceneManager.LoadScene("Niveau1");
    }
    public void quitterPartie()
    {
        Application.Quit();
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    void Start()
    {
        decompteVies = 3;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("lave"))
        {
            decompteVies -= 1;
            vies[decompteVies].SetActive(false);
        }
        if (decompteVies == 0)
        {
            defaite.SetActive(true);
        }
    }
}


