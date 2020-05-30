using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathanddoor : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GameObject.Find("Door").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if ((collision.gameObject.tag == "door")&&(Input.GetKey(KeyCode.D)))
        {
            anim.Play("OpenDoor");
            anim.SetBool("ColDoor", true);
        }
        else if ((collision.gameObject.tag == "door"))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            anim.SetBool("ColDoor", false);
        }
    }
}
