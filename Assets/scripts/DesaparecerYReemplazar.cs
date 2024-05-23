using UnityEngine;

public class DesaparecerYReemplazar : MonoBehaviour
{
    public GameObject objetoReemplazo; // El objeto que aparecerá cuando el personaje se acerque
    public float distanciaActivacion = 2.0f; // Distancia a la que el objeto desaparece

    private Transform playerTransform;

    void Start()
    {
        // Encuentra al jugador por su etiqueta "Player"
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Comprueba la distancia entre el objeto y el jugador
        if (Vector3.Distance(transform.position, playerTransform.position) < distanciaActivacion)
        {
            // Desaparece el objeto actual
            gameObject.SetActive(false);

            // Aparece el objeto de reemplazo en la misma posición y rotación
            Instantiate(objetoReemplazo, transform.position, transform.rotation);
        }
    }
}
