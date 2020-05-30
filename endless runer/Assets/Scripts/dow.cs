using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dow : MonoBehaviour
{
    private Animator anim;
    public BoxCollider2D box;
    public GameObject he;
    public float oss;
    public float osf;
    public float lss;
    public float lsf;
    public bool kuv1;
    void coll()
    {
        box.size = new Vector2(box.size.x, oss);
        box.offset = new Vector2(box.offset.x, osf);
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
        he = (GameObject)this.gameObject;

        oss = box.size.y;
        osf = box.offset.y;
    }
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.S))
        {
            box.size = new Vector2(box.size.x, lss);
            box.offset = new Vector2(box.offset.x, lsf);
            anim.SetBool("kuv", true);
             anim.Play("downing");
        
        }
        else
        {

          
            anim.SetBool("kuv", false); 
        }
       
    }
    }
