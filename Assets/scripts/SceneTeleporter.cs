using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleporter : MonoBehaviour
{
    public string targetSceneName; // Nombre de la escena a la que se teletransportará el jugador

    void OnTriggerEnter(Collider other)
    {
        // Comprobar si el objeto que entra en el trigger es el jugador
        if (other.CompareTag("Player"))
        {
            TeleportToScene();
        }
    }

    void TeleportToScene()
    {
        // Cargar la escena especificada
        if (!string.IsNullOrEmpty(targetSceneName))
        {
            SceneManager.LoadScene(targetSceneName);
        }
        else
        {
            Debug.LogError("El nombre de la escena de destino no está especificado.");
        }
    }
}