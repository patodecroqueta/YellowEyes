using UnityEngine;
using UnityEngine.Playables;

public class StartSequenceWithCinematic : MonoBehaviour
{
    public PlayableDirector cinematic; // El Timeline que representa la cinemática
    public Camera playerCamera;  // La cámara del jugador
    public AudioSource musicSource; // El AudioSource que reproducirá la música

    void Start()
    {
        // Asegúrate de que la cámara del jugador esté inicialmente desactivada
        if (playerCamera != null)
        {
            playerCamera.gameObject.SetActive(false);
        }

        // Iniciar la música y la cinemática
        if (musicSource != null)
        {
            musicSource.Play();
        }

        if (cinematic != null)
        {
            cinematic.stopped += OnCinematicFinished; // Suscribir al evento para cuando termine la cinemática
            cinematic.Play();
        }
    }

    void OnCinematicFinished(PlayableDirector director)
    {
        // Activar la cámara del jugador
        if (playerCamera != null)
        {
            playerCamera.gameObject.SetActive(true);
        }

        // Desuscribir del evento para evitar posibles errores si la cinemática se reproduce de nuevo
        cinematic.stopped -= OnCinematicFinished;
    }
}
