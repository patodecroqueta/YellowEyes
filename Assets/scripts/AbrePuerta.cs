using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AbrePuerta : MonoBehaviour
{
    public Animator animator;
    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag=="Player"){
            animator.SetTrigger("abrir");
        }
    }
}
