using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HacerDanio : MonoBehaviour
{
    public int damage = 12;
    public GameObject Player;
    private Animator animacion;
    private Animator animacionZombie;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        animacion = Player.GetComponent<Animator>();
        animacionZombie = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(Player.GetComponent<Jugador>().vida > 0)
            {
                Player.GetComponent<Jugador>().vida -= damage;
                animacion.SetBool("MordidoZombie", true);
                animacionZombie.SetBool("EstaAtacando", true);
            } else{
                animacion.SetBool("EstoyMuerto", true);
                SceneManager.LoadScene(2);
            }
        }
    }

    void FixedUpdate(){
        if (animacionZombie.GetBool("EstaAtacando") == true){
            animacionZombie.SetBool("EstaAtacando", false);

        }
        if (animacion.GetBool("MordidoZombie") == true){
            animacion.SetBool("MordidoZombie", false);

        }
    }

}
