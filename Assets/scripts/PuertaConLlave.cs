using UnityEngine;

public class PuertaConLlave : MonoBehaviour
{
    public GameObject puerta; // Referencia al GameObject de la puerta
    public string llaveTag = "Llave"; // Etiqueta del collider de la llave

    private bool llaveRecogida = false;

    void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que entra en contacto tiene la etiqueta de la llave
        if (other.CompareTag(llaveTag))
        {
            // Desactivar la puerta
            puerta.SetActive(false);
            Debug.Log("¡Puerta abierta!");
            llaveRecogida = true;

            // Desactivar el collider de la llave para evitar que se recoja de nuevo
            other.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        // Para demostración: recoger la llave con la tecla "Espacio"
        if (Input.GetKeyDown(KeyCode.Space) && !llaveRecogida)
        {
            // Simulamos que el jugador recoge la llave
            Collider[] colliders = Physics.OverlapSphere(transform.position, 1f);
            foreach (Collider collider in colliders)
            {
                if (collider.CompareTag(llaveTag))
                {
                    // Desactivar la puerta
                    puerta.SetActive(false);
                    Debug.Log("¡Puerta abierta!");
                    llaveRecogida = true;

                    // Desactivar el collider de la llave para evitar que se recoja de nuevo
                    collider.gameObject.SetActive(false);
                    break;
                }
            }
        }
    }
}