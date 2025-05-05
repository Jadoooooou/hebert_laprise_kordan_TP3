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
}