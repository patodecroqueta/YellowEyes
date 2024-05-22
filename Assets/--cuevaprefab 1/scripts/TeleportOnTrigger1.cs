using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportOnTrigger1 : MonoBehaviour
{
    public string sceneName; // El nombre de la siguiente escena a la que te teletransportarás

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
