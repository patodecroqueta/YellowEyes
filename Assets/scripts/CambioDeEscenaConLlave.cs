using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscenaConLlave : MonoBehaviour
{
    public string llaveTag = "Llave"; // Etiqueta de la llave
    public string escenaACargar; // Nombre de la escena a cargar

    private bool tieneLlave = false;

    void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que colisiona tiene la etiqueta de la llave
        if (other.CompareTag(llaveTag))
        {
            // Recoger la llave
            tieneLlave = true;

            // Desactivar el collider de la llave para evitar que se recoja de nuevo
            other.gameObject.SetActive(false);
        }

        // Verificar si el jugador tiene la llave y colisiona con otro collider
        if (tieneLlave && !string.IsNullOrEmpty(escenaACargar))
        {
            // Cambiar a la nueva escena
            SceneManager.LoadScene(escenaACargar);
        }
    }
}