using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_jeu : MonoBehaviour
{
    public GameObject porteGauche;
    public GameObject porteDroite;

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
}