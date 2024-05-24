using UnityEngine;

public class SpawnObjectsOnTrigger : MonoBehaviour
{
    // Array de prefabs que se van a instanciar
    [SerializeField] private GameObject[] objectsToSpawn;

    // Puntos donde se instanciarán los objetos
    [SerializeField] private Transform[] spawnPoints;

    // Método que se ejecuta cuando otro objeto entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verificamos si el objeto que entra en el trigger es el jugador (u otro objeto específico)
        if (other.CompareTag("Player"))
        {
            // Instanciar cada objeto en su respectivo punto de spawn
            for (int i = 0; i < objectsToSpawn.Length; i++)
            {
                Instantiate(objectsToSpawn[i], spawnPoints[i].position, spawnPoints[i].rotation);
            }
        }
    }
}
