using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoor : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Player") && (Input.GetKey(KeyCode.D)))
        {
            anim.Play("OpenDoor");
            anim.SetBool("ColDoor", true);
        }
        else if ((collision.gameObject.tag == "Player"))
        {

            
            anim.SetBool("ColDoor", false);
        }
    }
}
