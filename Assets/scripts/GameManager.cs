using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Atributos del juego
    public float salud;
    public int saludMaxima;
    //public int puntuacion = 0;
    //public int puntuacionMaxima = 0;

    //ESTO SE PUEDE HACER CON EVENTOS
    public Image imageVida;
    //public TextMeshProUGUI textoPuntuacion;
    //public TextMeshProUGUI textoPuntuacionMaxima;

    public List<GameObject> objetosAActivarCuandoGameOver;

    private static string KEY_HIGHSCORE = "HIGHSCORE";

    private void Awake()
    {
        ActualizarBarraDeSalud();
    }
    private void Update()
    {
        if (salud == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ReiniciarJuego();
            }
        }
    }
   
    private void ActualizarBarraDeSalud()
    {
        imageVida.fillAmount = salud / saludMaxima;
    }
    public void Puntuar(int puntuacion)
    {

    }
    public void DecrementarSalud(int decrementoSalud)
    {
        salud = salud - decrementoSalud;
        if (salud <= 0)
        {
            salud = 0;
            TerminarJuego();
        }
        ActualizarBarraDeSalud();
    }
    public void IncrementarSalud(int incrementoSalud)
    {
        salud = salud + incrementoSalud;
        if (salud >= saludMaxima)
        {
            salud = saludMaxima;
        }
        ActualizarBarraDeSalud();
    }
    public void TerminarJuego()
    {
        foreach (GameObject objeto in objetosAActivarCuandoGameOver)
        {
            objeto.SetActive(true);
        }
 
    }
    public void ReiniciarJuego()
    {
        SceneManager.LoadScene(0);
    }

}
