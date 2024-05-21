using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera playerCamera;   // Asigna la cámara del jugador en el inspector de Unity
    public float zoomInFOV = 20f; // Campo de visión para el zoom in
    public float zoomOutFOV = 60f;// Campo de visión para el zoom out

    private bool isZoomedIn = false; // Estado del zoom

    void Update()
    {
        // Comprobar si se ha presionado la tecla 'Z'
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ToggleZoom();
        }
    }

    void ToggleZoom()
    {
        // Alternar entre zoom in y zoom out
        if (isZoomedIn)
        {
            playerCamera.fieldOfView = zoomOutFOV;
        }
        else
        {
            playerCamera.fieldOfView = zoomInFOV;
        }
        isZoomedIn = !isZoomedIn; // Invertir el estado del zoom
    }
}