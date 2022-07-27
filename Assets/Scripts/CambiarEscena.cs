using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public GameObject Slide;

    public void CargarEscena(string nombreEscena)
    {
        Instantiate(Slide);
        StartCoroutine(Esperar(nombreEscena));
    }

    IEnumerator Esperar(string nombreEscena)
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(nombreEscena);
    }
}
