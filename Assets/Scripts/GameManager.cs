using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject zombie;
    public GameObject zombieEspecial1;
    public int numeroZombies;
    public List<GameObject> listaZombiesNormales;

    private float xMin = -120;
    private float xMax = -65;
    private float zMin = -13;
    private float zMax = 10;

    public int numeroOla = 1;
    public bool juegoActivo;
    private float intervaloGeneracion = 1.5f;

    void Start()
    {
        juegoActivo = true;
        StartCoroutine(GenerarZombies());
    }

    void Update()
    {
        
    }

    // Genera una posición spawn aleatoria para zombies
    Vector3 PosicionRamdom()
    {
        float xPos = Random.Range(xMin, xMax);
        float zPos = Random.Range(zMin, zMax);
        return new Vector3(xPos, 0, zPos);
    }

    // Mientras el juego está activo genera un objetivo aleatorio
    IEnumerator GenerarZombies()
    {
        while (juegoActivo)
        {
            yield return new WaitForSeconds(intervaloGeneracion);
            int i = Random.Range(0, listaZombiesNormales.Count);

            if (juegoActivo)
            {
                Instantiate(listaZombiesNormales[i], PosicionRamdom(), listaZombiesNormales[i].transform.rotation);
                numeroZombies = GameObject.FindGameObjectsWithTag("Zombie").Length;

                if (numeroZombies % 5 == 0) // cada cinco zombies se genera un zombie especial
                {
                    //Vector3 espacioRamdom = new Vector3(0, 0, -15);
                    Instantiate(zombieEspecial1, PosicionRamdom(), zombieEspecial1.transform.rotation);
                }
            }            
        }
    }

}
