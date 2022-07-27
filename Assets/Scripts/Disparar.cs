using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject SonidoDisparo;
    //Agregan punto de inicio de donde la bala saldra.
    public GameObject BalaInicio;
    //Agregan Bala Prefab
    public GameObject BalaPrefab;
    //Agregar Bala Velocidad
    public float BalaVelocidad;
    private float tiempoEspera = 0.25f;
    private float tiempoSigDisparo = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > tiempoSigDisparo)
        {
            tiempoSigDisparo = Time.time + tiempoEspera;
            GameObject SonidoBala = Instantiate(SonidoDisparo);
            Destroy(SonidoBala, 1.0f);
            //1-Instanciar la BalaPrefab en las posiciones de BalaInicio
            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject;

            //Obtener Rigidbody para agregar Fuerza. 
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

            //Agregar la fuerza a la Bala
            rb.AddForce(transform.forward * BalaVelocidad);

            //Debemos Destruir la bala
            Destroy(BalaTemporal, 2.0f);
        }
    }
}
