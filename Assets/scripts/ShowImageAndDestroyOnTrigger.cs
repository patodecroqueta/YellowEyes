using UnityEngine;

public class ShowImageAndDestroyOnTrigger : MonoBehaviour
{
    public GameObject canvasImage;  // La imagen que se mostrará en el Canvas
    public float displayTime = 5f;  // Tiempo en segundos que se mostrará la imagen

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Asegúrate de que el objeto que colisiona tenga el tag "Player"
        {
            canvasImage.SetActive(true);  // Mostrar la imagen

            // Iniciar una corrutina para destruir la imagen después del tiempo especificado
            Destroy(canvasImage, displayTime);
        }
    }
}