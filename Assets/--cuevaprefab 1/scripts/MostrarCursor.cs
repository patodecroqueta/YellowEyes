using UnityEngine;

public class MostrarCursor : MonoBehaviour
{
    void Update()
    {
        // Comprueba si la tecla Tab ha sido presionada
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Activa el cursor y permite su movimiento
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
