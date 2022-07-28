using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Jugador : MonoBehaviour
{
    public GameManager gameManager;

  private Rigidbody jugador;
  public int vida = 100;
  public int puntaje = 0;
  public Slider vidaVisual;
  private Vector3 movimiento;
  private float velocidad = 5;

  private float sensibilidad = 350;
  private Animator animacion;


    public TextMeshProUGUI puntajeTxt;

  void Start()
  {
        jugador = GetComponent<Rigidbody>();
        animacion = GetComponent<Animator>();
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

    }

  void Update()
  {
        puntajeTxt.text = puntaje.ToString();

        // Actualizar barra de vida
        vidaVisual.GetComponent<Slider>().value = vida;

    movimiento = Vector3.zero;
    if (gameManager.juegoActivo == true) {
        // Movimiento vertical
        if (Input.GetKey(KeyCode.W) ){
            movimiento.z = -1;
            //transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));

        } 
        else if (Input.GetKey(KeyCode.S)){
            movimiento.z = 1;
        }
        // Movimiento horizontal
        if (Input.GetKey(KeyCode.D)){
            movimiento.x = -1;
        } 
        else if (Input.GetKey(KeyCode.A) ){
            movimiento.x = 1;
        }

        // Movimiento Apuntar horizonal
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) ){
            float rotation = Input.GetAxis("Horizontal") * sensibilidad;
            rotation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
        } 

        // Control de animacion moverse
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) ||Input.GetKey(KeyCode.D) ){
            animacion.SetBool("EstaMoviendose", true);
        } 
        else{
            animacion.SetBool("EstaMoviendose", false);
        }
        animacion.SetBool("MordidoZombie", false);
        }
    }

    void FixedUpdate(){
        Mover(movimiento);
        //jugador.transform.LookAt(jugador.transform.position + movimiento);
    }

    void Mover(Vector3 direction){
        jugador.MovePosition(jugador.position + direction.normalized * velocidad * Time.fixedDeltaTime);
    }
}
