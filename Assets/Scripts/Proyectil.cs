using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public int hit = 1;
    public GameObject Enemigo;
    // Update is called once per frame
    void Start()
    {
        Enemigo = GameObject.FindGameObjectWithTag("Enemigo");
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            if (Enemigo.GetComponent<VidaEnemigo>().puntosVida > 0)
            {
                Enemigo.GetComponent<VidaEnemigo>().TakeHit(hit);
                Destroy(gameObject);
            }
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("tuñaña")
            
        var enemigo = collision.collider.GetComponent<VidaEnemigo>();

        if (enemigo)
        {
            enemigo.TakeHit(hit);
        }
        Destroy(gameObject);
            
    }*/
}
