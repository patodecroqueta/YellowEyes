using UnityEngine;
using UnityEngine.UI;  // Necesario para usar la clase Image

public class ShowPhotoOnTrigger : MonoBehaviour
{
    public Image photo; // La imagen que se mostrará/ocultará

    void Start()
    {
        if (photo != null)
        {
            photo.gameObject.SetActive(false); // Asegúrate de que la foto esté inicialmente oculta
        }
    }

    // Se llama cuando otro collider entra en el trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && photo != null) // Asegúrate de que el objeto que entra tenga el tag "Player"
        {
            photo.gameObject.SetActive(true); // Muestra la foto
        }
    }

    // Se llama cuando otro collider sale del trigger
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && photo != null) // Asegúrate de que el objeto que sale tenga el tag "Player"
        {
            photo.gameObject.SetActive(false); // Oculta la foto
        }
    }
}
