using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuPanel; // Arrastra tu Panel del menú aquí en el Inspector

    private bool isMenuActive = false;

    void Start()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(isMenuActive); // Asegúrate de que el menú esté oculto al inicio
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleMenu();
        }
    }

    void ToggleMenu()
    {
        isMenuActive = !isMenuActive;
        if (menuPanel != null)
        {
            menuPanel.SetActive(isMenuActive);
        }
    }
}