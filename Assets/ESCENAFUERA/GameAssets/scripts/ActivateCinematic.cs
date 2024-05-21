using UnityEngine;
using UnityEngine.Playables;

public class ActivateCinematic : MonoBehaviour
{
    public PlayableDirector cinematic; // El Timeline que representa la cinemática
    public GameObject[] objectsToActivate; // Los objetos que se activarán

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Iniciar la cinemática
            if (cinematic != null)
            {
                cinematic.Play();
            }

            // Activar los objetos
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
            }
        }
    }
}