
using UnityEngine;

public class AbrirPuertaConLlave1 : MonoBehaviour
{
    public GameObject llave;
    public Animator puertaAnimator;
    private bool tienellave = false;

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que colisionó es la llave
        if (other.gameObject == llave)
        {
            tienellave = true;
            Destroy(llave); // Opcional: eliminar la llave al recogerla
        }

        // Verificar si el objeto tiene la llave y colisionó con la puerta
        if (tienellave && other.gameObject.CompareTag("Player"))
        {
            // Abrir la puerta usando el Animator
            puertaAnimator.SetTrigger("Abrir");
        }
    }
}