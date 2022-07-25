using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI puntosTexto;

    public void Setup(int puntuacion)
    {
        gameObject.SetActive(true);
        puntosTexto.text = puntuacion.ToString() + " Puntos";
    }

    public void BotonReiniciar()
    {
        SceneManager.LoadScene(1);
    }

    public void BotonMenu()
    {
        SceneManager.LoadScene(0);
    }

}
