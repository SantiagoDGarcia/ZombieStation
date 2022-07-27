using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject Boton;

    void Start()
    {
        Instantiate(GameOver);
    }

    public void BotonReiniciar()
    {
        Instantiate(Boton);
        SceneManager.LoadScene(1);
    }

    public void BotonMenu()
    {
        Instantiate(Boton);
        SceneManager.LoadScene(0);
    }

}
