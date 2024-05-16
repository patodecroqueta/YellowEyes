using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public List<string> items;

    public void AddItem(GameObject item){
        items.Add(item.name);
    }

    public bool HasItem(string nombre){
        foreach(string item in items){
            if (item==nombre){
                return true;
            }
        }
        return false;
    }
}
