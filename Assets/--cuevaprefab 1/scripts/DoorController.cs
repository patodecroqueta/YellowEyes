using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door; // Referencia al GameObject de la puerta
    public string keyTag = "Key"; // Tag del objeto llave
    public string doorTag = "Door"; // Tag del objeto puerta

    private bool hasKey = false; // Variable para controlar si el jugador tiene la llave

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el jugador tiene la llave y está colisionando con la puerta
        if (other.CompareTag(doorTag) && hasKey)
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        // Desactiva el collider y el renderizador de la puerta para simular que se abre
        door.GetComponent<Collider>().enabled = false;
        door.GetComponent<Renderer>().enabled = false;
    }

    // Método para añadir la llave al inventario del jugador
    public void AddKeyToInventory()
    {
        hasKey = true;
    }
}