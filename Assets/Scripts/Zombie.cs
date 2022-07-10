using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private GameObject jugador;
    private float velocidad = 1.1f;

    private Rigidbody enemigo;

    void Start()
    {
        enemigo = GetComponent<Rigidbody>();
        jugador = GameObject.Find("Jugador");
    }

    void Update()
    {
        SeguirJugador();   
    }

    void SeguirJugador()
    {
        // Rota el zombie hacia el jugador
        transform.LookAt(jugador.transform);
        // Mueve el zombie hacia el jugador
        transform.position = Vector3.MoveTowards(transform.position, jugador.transform.position, velocidad * Time.deltaTime);
    }
}
