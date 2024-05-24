using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToNextScene : MonoBehaviour
{
    // Nombre de la próxima escena que se cargará
    [SerializeField] private string nextSceneName;

    // Método que se ejecuta cuando otro objeto entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verificamos si el objeto que entra en el trigger es el jugador (u otro objeto específico)
        if (other.CompareTag("Player"))
        {
            // Cargar la siguiente escena
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
