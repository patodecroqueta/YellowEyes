using UnityEngine;

public class abrepuertaconllave : MonoBehaviour
{
    public GameObject puerta;
    public GameObject llave;
    private bool tieneLlave = false;
    private bool puertaAbierta = false;

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que colisionó es la llave
        if (other.gameObject == llave)
        {
            tieneLlave = true;
            //Destroy(llave); // Opcional: eliminar la llave al recogerla
        }

        // Verificar si el objeto tiene la llave y colisionó con la puerta
        if (tieneLlave && other.gameObject == puerta && !puertaAbierta)
        {
            // Abrir la puerta
            puerta.transform.Rotate(0, 90, 0); // Cambiar según la orientación de la puerta
            puertaAbierta = true;
        }
    }
}