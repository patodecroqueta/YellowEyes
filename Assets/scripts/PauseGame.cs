using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseText; // Arrastra el objeto de texto aquí en el Inspector

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGameFunction();
            }
        }
    }

    void PauseGameFunction()
    {
        Time.timeScale = 0f; // Pausa el juego
        isPaused = true;
        pauseText.SetActive(true); // Muestra el texto de pausa
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Reanuda el juego
        isPaused = false;
        pauseText.SetActive(false); // Oculta el texto de pausa
    }
}
