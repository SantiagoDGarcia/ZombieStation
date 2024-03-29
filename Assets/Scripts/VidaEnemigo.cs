using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public int puntosVida;
    public int vidaMaxima = 5;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        puntosVida = vidaMaxima;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    public void TakeHit(int golpe)
    {
        puntosVida -= golpe;
        if(puntosVida <= 0)
        {
            Destroy(gameObject);
            Player.GetComponent<Jugador>().puntaje++;

        }
    }
}
