using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private GameObject jugador;
    private float velocidad = 1.5f;

    public GameObject ZombieSonido;

    private Rigidbody enemigo;

    void Start()
    {
        enemigo = GetComponent<Rigidbody>();
        SonidoZ();
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
        //enemigo.Distance(transform.position, jugador.transform.position, velocidad * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, jugador.transform.position, velocidad * Time.deltaTime);
    }
    public void SonidoZ()
    {
        GameObject ZombieS = Instantiate(ZombieSonido);
        Destroy(ZombieS, 2f);
    }
            
}
