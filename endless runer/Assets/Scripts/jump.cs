using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody2D her;
    public bool ReadG;
    public int Fjump;
    Animator anim;
    
    void Start()
    {
       
        her = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        anim.SetFloat("vSpeed", her.velocity.y);

        if ((Input.GetMouseButtonDown(0)) && ReadG == true)
            {
                her.AddForce(new Vector2(0, Fjump), ForceMode2D.Force);
                ReadG = false;
            anim.SetBool("Ground", false);
            anim.Play("Jump");
            
        }
        if((Input.GetKeyDown(KeyCode.S)) && ReadG == false)
        {
            her.transform.position = new Vector2(-2.29f, -2.93f);
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ReadG = true;
            anim.SetBool("Ground", true);

        }
        else
        {
            ReadG = false;
            anim.SetBool("Ground", false);
        }
    }
}
