using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlorScrol : MonoBehaviour
{
    public  float florspeed = -0.1f;

    public GameObject fl;
    
    void Start()
    {
        fl = (GameObject)this.gameObject;
     
    }

  
    void FixedUpdate()
    {

        fl.transform.Translate(new Vector2(Time.deltaTime, 0) * florspeed);
  
    }
}

