using UnityEngine;

public class DeactivateObjectsOnTrigger : MonoBehaviour
{
    // Array de objetos que se van a desactivar
    [SerializeField] private GameObject[] objectsToDeactivate;

    // Método que se ejecuta cuando otro objeto entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verificamos si el objeto que entra en el trigger es el jugador (u otro objeto específico)
        if (other.CompareTag("Player"))
        {
            // Desactivar cada objeto en el array
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(false);
            }
        }
    }
}