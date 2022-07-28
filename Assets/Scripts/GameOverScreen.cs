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
    public TextMeshProUGUI puntajeGOTxt;
    public string puntajeGO;

    void Start()
    {
        puntajeGO = GameObject.FindGameObjectWithTag("Player").GetComponent<Jugador>().puntaje.ToString(); ;
        SetPuntaje(puntajeGO);
        Instantiate(GameOver);
    }

    public void SetPuntaje(string puntaje)
    {
        puntajeGOTxt.text = puntaje + " Puntos!";
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
