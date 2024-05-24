using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorDesactivador : MonoBehaviour
{
    public string tagObjetoActivador;
    public GameObject[] objetosActivables;
    public GameObject[] objetosDesactivables;
    public float tiempoEsperaRestaurar;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tagObjetoActivador))
        {
            GetComponent<Collider>().enabled = false;
            Invoke("Restaurar",tiempoEsperaRestaurar);
            foreach (GameObject objetoActivable in objetosActivables)
            {
                objetoActivable.SetActive(true);
            }
            foreach (GameObject objetoDesactivable in objetosDesactivables)
            {
                objetoDesactivable.SetActive(false);
            }
        }
    }
    void Restaurar()
    {
        foreach (GameObject objetoActivable in objetosActivables)
            {
                objetoActivable.SetActive(false);
            }
            foreach (GameObject objetoDesactivable in objetosDesactivables)
            {
                objetoDesactivable.SetActive(true);
            }
    }
}
