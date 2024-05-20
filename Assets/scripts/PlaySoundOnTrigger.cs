using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    public AudioSource audioSource;  // El AudioSource que reproducirá el sonido

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Asegúrate de que el objeto que colisiona tenga el tag "Player"
        {
            audioSource.Play();
        }
    }
}