using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private Rigidbody jugador;
    
    private float velocidad = 3;
    void Start()
    {
        jugador = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento vertical
        float movimientoVertical = Input.GetAxis("Vertical");

        if (movimientoVertical>0f){
            transform.Translate(Vector3.back  * velocidad * Time.deltaTime);
        } 
        if (movimientoVertical<0f) {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        // Movimiento horizontal
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        if (movimientoHorizontal>0f){
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        } 
        if (movimientoHorizontal<0f) {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }

    }
}
