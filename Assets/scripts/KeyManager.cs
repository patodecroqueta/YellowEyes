using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public GameObject imagenllave;
    void OnTriggerEnter(Collider c){
        if (c.gameObject.name=="Llave"){
            //1. Desaparece la llave
            //Destroy(c.gameObject);
            //1. Cambiar la llave de posición
            c.gameObject.transform.position = new Vector3(0, -100, 0);
            //2. Aparece en la interfaz de usuario
            imagenllave.SetActive(true);
            //3. Añadimos al inventario
            GetComponent<Inventario>().AddItem(c.gameObject);//Añadir la llave al inventario
        }
    }
}
