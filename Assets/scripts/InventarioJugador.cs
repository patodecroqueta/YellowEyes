using UnityEngine;
using System.Collections.Generic;

public class InventarioJugador : MonoBehaviour
{
    private List<string> inventario = new List<string>();

    public void AgregarObjeto(string objeto)
    {
        inventario.Add(objeto);
        Debug.Log("Objeto añadido al inventario: " + objeto);
    }

    public bool ContieneObjeto(string objeto)
    {
        return inventario.Contains(objeto);
    }

    public void MostrarInventario()
    {
        foreach (string obj in inventario)
        {
            Debug.Log("Inventario: " + obj);
        }
    }
}
