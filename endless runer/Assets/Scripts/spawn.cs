using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject prefab;
    public float interval = 1.0f;
    public GameObject pt;
    public GameObject par;



    void Start()
    {
        InvokeRepeating("SpawnNext", interval, interval);
        
        
        
    }
    public void SetParent(GameObject newParent)
    {
        
        prefab.transform.parent = newParent.transform;
        Debug.Log("Player's Parent: " + prefab.transform.parent.name);
            if (newParent.transform.parent != null)
            {
           
            Debug.Log("Player's Grand parent: " + prefab.transform.parent.parent.name);
            }
    }

    public void DetachFromParent()
    {   
        transform.parent = null;
    }

    void Update()
    {
        if (prefab.transform.position.x < pt.transform.position.x)
        {
            Destroy(prefab);

        }


    }
    
    void SpawnNext()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);



    }
   
}

