using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class Remy : MonoBehaviour
{

    [SerializeField]
    private float walkSpeed;
    [SerializeField]
    private float runSpeed;
    [SerializeField]
    private float angularSpeed;

    private float speed;

    private float h, v;

    bool andando = false;
    bool corriendo = false;

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        Animar();
        Mover();
        Desplazar();
    }
    void Animar()
    {
        if (v > 0)
        {
            andando = true;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                corriendo = true;
            }
            else
            {
                corriendo = false;
            }
        }
        else
        {
            andando = false;
            corriendo = false;
        }
        GetComponent<Animator>().SetBool("andando", andando);
        GetComponent<Animator>().SetBool("corriendo", corriendo);
    }
    void Mover()
    {
        String animacion = GetComponent<Animator>().GetCurrentAnimatorClipInfo(0)[0].clip.name;
        //Si está cayendo, salimos
        if (animacion == "Fall Flat") return;
        //Si está levantando, salimos
        if (animacion == "Standing Up") return;
        //Puedes continuar
        if (v > 0)
        {
            if (corriendo)
            {
                speed = runSpeed;
            }
            else if (andando)
            {
                speed = walkSpeed;
            }
            //transform.Translate(0, 0, v * speed * Time.deltaTime);
        }
        transform.Rotate(0, h * angularSpeed * Time.deltaTime, 0);
    }
    void Desplazar()
    {
        CharacterController cc = GetComponent<CharacterController>();
        if (!cc.isGrounded)
        {
            cc.Move(-transform.up * speed * Time.deltaTime);
        }
        else
        {
            //cc.Move(transform.forward * cc.Move(transform.forward.x, -1, transform.forward.z * speed * Time.deltaTime); speed * Time.deltaTime);
            cc.Move(new Vector3(transform.forward.x, -1, transform.forward.z) * v * speed * Time.deltaTime);
        }
    }
}
