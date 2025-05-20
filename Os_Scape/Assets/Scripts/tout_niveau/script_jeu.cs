using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Joueur : MonoBehaviour
{
    public GameObject[] vies;
    public int decompteVies;

    public GameObject defaite;

    private bool isInvincible = false;

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
        if (other.CompareTag("lave") && !isInvincible)
        {
            decompteVies -= 1;
            vies[decompteVies].SetActive(false);

            if (decompteVies == 0)
            {
                defaite.SetActive(true);
                StartCoroutine(ChargerMenuApresDefaite());
            }
            else
            {
                StartCoroutine(ActiverInvincibilite());
            }
        }
    }

    IEnumerator ActiverInvincibilite()
    {
        isInvincible = true;
        yield return new WaitForSeconds(2f);
        isInvincible = false;
    }

    IEnumerator ChargerMenuApresDefaite()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Menu");
    }
}
