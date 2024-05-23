using UnityEngine;
using System.Collections;

public class TriggerPlayMusicAfterDelay : MonoBehaviour
{
    public AudioSource audioSource; // El AudioSource que reproducirá la canción
    public float delay = 3.0f; // Tiempo de espera antes de que suene la canción

    // Este método se llama cuando otro Collider entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto que entra en el trigger es el jugador
        if (other.CompareTag("Player"))
        {
            // Inicia la corrutina que espera y luego reproduce la canción
            StartCoroutine(PlayMusicAfterDelay());
        }
    }

    private IEnumerator PlayMusicAfterDelay()
    {
        // Espera el tiempo especificado
        yield return new WaitForSeconds(delay);

        // Reproduce la canción si el AudioSource está asignado y no se está reproduciendo ya
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
