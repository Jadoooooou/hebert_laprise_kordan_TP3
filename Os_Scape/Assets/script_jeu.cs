using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_jeu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void jouer()
    {
        SceneManager.LoadScene("Niveau1");
    }
}