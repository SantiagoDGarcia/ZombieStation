using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestuirFueraBorde : MonoBehaviour
{
    private float limiteIzquierda = -4000;
    private float limiteInferior = 0;

    // Update is called once per frame
    void Update()
    {
        // 
        if (transform.position.x < limiteIzquierda)
        {
            Destroy(gameObject);
        } 
        // Si sale del suelo, se destruye
        else if (transform.position.y < limiteInferior)
        {
            Destroy(gameObject);
        }

    }
}
