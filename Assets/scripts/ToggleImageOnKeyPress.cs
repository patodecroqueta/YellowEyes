using UnityEngine;

public class ToggleImageOnKeyPress : MonoBehaviour
{
    public GameObject image; // Referencia al GameObject de la imagen que quieres mostrar

    void Update()
    {
        // Si se presiona la tecla "C"
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Si la imagen está activa, la desactiva. Si está desactivada, la activa.
            image.SetActive(!image.activeSelf);
        }
    }
}