using UnityEngine;
using UnityEngine.SceneManagement;

public class RecogerObjetoYTeletransportar1 : MonoBehaviour
{
    public string nombreObjeto = "NuevoObjeto"; // Nombre del objeto que se añadirá al inventario
    public float distanciaRecogida = 1.0f; // Distancia a la que se puede recoger el objeto
    public string nombreEscenaDestino; // Nombre de la escena a la que se teletransportará el jugador

    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, playerTransform.position) < distanciaRecogida)
        {
            // Añadir el objeto al inventario del jugador
            InventarioJugador inventario = playerTransform.GetComponent<InventarioJugador>();
            if (inventario != null)
            {
                inventario.AgregarObjeto(nombreObjeto);
                // Destruir el objeto recogido
                Destroy(gameObject);
                // Teletransportar al jugador a otra escena
                SceneManager.LoadScene(nombreEscenaDestino);
            }
        }
    }
}
