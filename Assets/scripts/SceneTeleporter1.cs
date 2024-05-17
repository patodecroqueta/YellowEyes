using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleporter1 : MonoBehaviour
{
    public string sceneToLoad; // Nombre de la escena a la que teletransportarse

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Verificar si el jugador entra en el teletransportador
        {
            SceneManager.LoadScene(sceneToLoad); // Cargar la escena especificada
        }
    }
}