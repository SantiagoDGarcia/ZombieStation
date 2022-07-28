using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HacerDanio : MonoBehaviour
{
    public int damage = 15;
    public bool gameOver = false;
    public GameObject Player;
    public GameObject Enemigo;
    private Animator animacion;
    private Animator animacionZombie;
    public GameManager gameManager;
    public CogerArmas cogerArmas;

    public GameObject Daño;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Enemigo = GameObject.FindGameObjectWithTag("Enemigo");
        animacion = Player.GetComponent<Animator>();
        animacionZombie = Enemigo.GetComponent<Animator>();
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        cogerArmas = GameObject.FindGameObjectWithTag("Player").GetComponent<CogerArmas>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(Player.GetComponent<Jugador>().vida > 0)
            {
                //animacionZombie.SetBool("EstaAtacando", true);
                Player.GetComponent<Jugador>().vida -= damage;
                //animacion.SetBool("MordidoZombie", true);
                Instantiate(Daño);

            } else{
                animacion.SetBool("EstoyMuerto", true);
                gameManager.juegoActivo = false;
                cogerArmas.DesactivarArma();
                StartCoroutine(Muerte());
            }
        }
    }

    void FixedUpdate(){
        /*
        if (animacionZombie.GetBool("EstaAtacando") == true){
            animacionZombie.SetBool("EstaAtacando", false);

        }
        if (animacion.GetBool("MordidoZombie") == true){
            animacion.SetBool("MordidoZombie", false);

        }*/
    }


    IEnumerator Muerte()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }

}
