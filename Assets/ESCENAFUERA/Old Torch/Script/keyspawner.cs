using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    public GameObject keyPrefab; // Prefab de la llave que aparecerá
    public Transform spawnLocation; // Lugar donde aparecerá la llave

    private bool keySpawned = false; // Para asegurarnos de que la llave solo aparezca una vez

    void OnTriggerEnter(Collider other)
    {
        // Comprobar si el objeto que entra en el trigger es el jugador
        if (other.CompareTag("Player") && !keySpawned)
        {
            SpawnKey();
        }
    }

    void SpawnKey()
    {
        // Instanciar la llave en la ubicación especificada
        if (keyPrefab != null && spawnLocation != null)
        {
            Instantiate(keyPrefab, spawnLocation.position, spawnLocation.rotation);
            keySpawned = true; // Marcar que la llave ha sido generada
        }
    }
}