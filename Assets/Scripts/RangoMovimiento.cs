using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoMovimiento : MonoBehaviour
{
    private int xMax = 40;
    private int xMin = -170;
    private int zMax = 71;
    private int zMin = -5;

    // Update is called once per frame
    void Update()
    {
        // Limitacion derecha del jugador
        if (transform.position.x < xMin){
            transform.position = new Vector3(xMin, transform.position.y, transform.position.z);
        }
        // Limitacion izquierda del jugador
        if (transform.position.x > xMax){
            transform.position = new Vector3(xMax, transform.position.y, transform.position.z);
        }
        // Limitacion superior del jugador
        if (transform.position.z < zMin){
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
        // Limitacion  del jugador
        if (transform.position.z > zMax){
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }              
    }
}
