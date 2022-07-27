using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerArmas : MonoBehaviour
{
    public GameObject[] armas;
    public GameObject EquiparSonido;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActivarArma(int numero)
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
        armas[numero].SetActive(true);
        GameObject equipar = Instantiate(EquiparSonido);
        Destroy(equipar, 2f);
    }

    public void DesactivarArma()
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
    }
}
