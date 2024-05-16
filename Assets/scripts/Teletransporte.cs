using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("Player")){
            bool tieneLlave = c.gameObject.GetComponent<Inventario>().HasItem("llave");
            if (tieneLlave){
                SceneManager.LoadScene("escena2dfinal");
            }
        }
    }
}
