using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacerDanio : MonoBehaviour
{
    public int damage = 15;
    public GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(Player.GetComponent<Jugador>().vida > 0)
            {
                Player.GetComponent<Jugador>().vida -= damage;
            }
        }
    }

}
