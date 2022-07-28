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

    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            if (other.GetComponent<VidaEnemigo>().puntosVida > 0)
            {
                other.GetComponent<VidaEnemigo>().TakeHit(hit);
                Destroy(gameObject);
            }
        }
    }
}
