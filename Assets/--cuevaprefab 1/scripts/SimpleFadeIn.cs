using UnityEngine;
using UnityEngine.UI;

public class SimpleFadeIn : MonoBehaviour
{
    public Image fadeImage; // Imagen negra que se usa para el efecto de fundido
    public float fadeDuration = 2.0f; // Duración del efecto de fundido

    private float fadeTimer;

    void Start()
    {
        // Asegúrate de que la imagen es completamente opaca al inicio
        fadeImage.color = Color.black;
        fadeTimer = fadeDuration;
    }

    void Update()
    {
        if (fadeTimer > 0)
        {
            fadeTimer -= Time.deltaTime;
            float alpha = fadeTimer / fadeDuration;
            fadeImage.color = new Color(0, 0, 0, alpha);
        }
        else
        {
            // Asegúrate de que la imagen es completamente transparente al final
            fadeImage.color = Color.clear;
            // Desactiva la imagen para que no interfiera con otros elementos de UI
            fadeImage.gameObject.SetActive(false);
        }
    }
}
