using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    private GameObject jugador;
    private Vector3 offset = new Vector3(12, 18, 23);

    void Start()
    {
        jugador = GameObject.Find("Jugador");
    }

    void Update()
    {
        // Seguir al jugador
        this.transform.position = jugador.transform.position + offset;
        
    }
}
