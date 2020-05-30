using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beating : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();  
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {         
            anim.SetBool("Beat", true);
            anim.Play("Beat");
        }
        else 
        {
            anim.SetBool("Beat", false);
        }
    }
}
