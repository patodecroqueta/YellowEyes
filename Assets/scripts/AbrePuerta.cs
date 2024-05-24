using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AbrePuerta : MonoBehaviour
{
    public Animator animator;

    public TextMeshProUGUI textMeshProUGUI;

    public GameObject visualKey;

    void OnTriggerEnter(Collider collider){
        print("OnTriggerEnter");
        if (collider.gameObject.GetComponent<Inventario>().HasItem("llave")){
            animator.SetTrigger("Abrir"); 
        } else {
            //textMeshProUGUI.text="Look for the:";
            //visualKey.SetActive(true);      

        }

    }
    void OnTriggerExit(Collider collider)
    {
        //textMeshProUGUI.text = "";
        //visualKey.SetActive(false);

    }
}
