using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private Rigidbody jugador;
    public int vida = 100;
    private Vector3 movimiento;
    private float velocidad = 5;

    void Start()
    {
        jugador = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movimiento = Vector3.zero;
        
        // Movimiento vertical
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) ){
            movimiento.z = -1;
        } 
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) ){
            movimiento.z = 1;
        }
        // Movimiento horizontal
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) ){
            movimiento.x = -1;
        } 
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) ){
            movimiento.x = 1;
        }

    }
    void FixedUpdate(){
        Mover(movimiento);
    }

    void Mover(Vector3 direction){
        jugador.MovePosition(jugador.position + direction.normalized * velocidad * Time.fixedDeltaTime);
    }
}
