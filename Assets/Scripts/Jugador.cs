using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    private Rigidbody jugador;
    public int vida = 100;
    public Slider vidaVisual;
    
    private float velocidad = 3;
    void Start()
    {
        jugador = GetComponent<Rigidbody>();
    }

    void Update()
    {

        // Actualizar barra de vida
        vidaVisual.GetComponent<Slider>().value = vida;

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
