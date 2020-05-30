using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public Collider2D Rooms;
    public GameObject PlaneA;
    float width;

    public GameObject PrefabBox;
    public GameObject PrefabFence;
    public GameObject PrefabLoader;
    public GameObject PrefabRoom1;
    public GameObject PrefabRoom2;
    public GameObject PrefabRoom3;
    public GameObject PrefabDoor;
    public GameObject PrefabWindow;

    public int PoolSize = 5;                                    
    public float spawnRate;
   

    private GameObject[] Box;
    private GameObject[] Fence;
    private GameObject[] Loader;
    private GameObject[] Room1;
    private GameObject[] Room2;
    private GameObject[] Room3;
    private GameObject[] Door;
    private GameObject[] Window;
    private int currentBox = 0;
    private int currentFence = 0;
    private int currentLoader = 0;
    private int currentRoom1 = 0;
    private int currentRoom2 = 0;
    private int currentRoom3 = 0;
    private int currentDoor = 0;
    private int currentWindow = 0;

    private Vector2 objectPoolPosition = new Vector2(-15, -25);       
    public float spawnXPosition = 30f;
    private float spawnYPosition = -2.9f;
    int[] room = new int[3];
    private float timeSinceLastSpawned;
    private int SorH;
    private int WinorDor;
    System.Random rand = new System.Random();

    void Start()
    {
         PlaneA = GameObject.Find("Room1");
        var collider2D = PlaneA.GetComponent<Renderer>();
        width = collider2D.bounds.size.x;
        Debug.Log(width);






        spawnRate = 8f;
        timeSinceLastSpawned = 0f;
        Box = new GameObject[PoolSize];
        Door = new GameObject[PoolSize];
        Fence = new GameObject[PoolSize];
        Loader = new GameObject[PoolSize];
        Room1 = new GameObject[PoolSize];
        Room2 = new GameObject[PoolSize];
        Room3 = new GameObject[PoolSize];
        Window = new GameObject[PoolSize];

        for (int i = 0; i < PoolSize; i++)
        {
            Box[i] = (GameObject)Instantiate(PrefabBox, objectPoolPosition, Quaternion.identity);
            Loader[i] = (GameObject)Instantiate(PrefabLoader, objectPoolPosition, Quaternion.identity);
            Fence[i] = (GameObject)Instantiate(PrefabFence, objectPoolPosition, Quaternion.identity);
            Room1[i] = (GameObject)Instantiate(PrefabRoom1, objectPoolPosition, Quaternion.identity);
            Room2[i] = (GameObject)Instantiate(PrefabRoom2, objectPoolPosition, Quaternion.identity);
            Room3[i] = (GameObject)Instantiate(PrefabRoom3, objectPoolPosition, Quaternion.identity);
            Door[i] = (GameObject)Instantiate(PrefabDoor, objectPoolPosition, Quaternion.identity);
            Window[i] = (GameObject)Instantiate(PrefabWindow, objectPoolPosition, Quaternion.identity);
            
        }
    }

    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        SorH = rand.Next(0, 3);
        
        if ((SorH == 0)||(SorH ==2))
        {
            if (timeSinceLastSpawned >= spawnRate)
            {
                int CountOBarrier = rand.Next(0, 4);
                
                for (int i = 0; i < CountOBarrier; i++)
                {
                    spawnRate = Random.Range(2.5f, 3f);
                    timeSinceLastSpawned += Time.deltaTime;
                    int chan1 = i;
                    switch (chan1)
                    {
                        case 0:
                            if (timeSinceLastSpawned >= spawnRate)
                            {
                                timeSinceLastSpawned = 0f;
                                float spawnYPosition = -2.89f;
                                float spawnXPosition = 30f;
                                RandomsBarrier(spawnXPosition, spawnYPosition);
                                spawnRate = 4f;
                            }

                            break;
                        case 1:
                            if (timeSinceLastSpawned >= spawnRate)
                            {
                                timeSinceLastSpawned = 0f;
                                float spawnYPosition = -2.89f;
                                float spawnXPosition = 30f;
                                RandomsBarrier(spawnXPosition, spawnYPosition);
                                spawnRate = 4f;
                            }
                            break;
                        case 2:
                            if (timeSinceLastSpawned >= spawnRate)
                            {
                                timeSinceLastSpawned = 0f;
                                float spawnYPosition = -2.89f;
                                float spawnXPosition = 30f;
                                RandomsBarrier(spawnXPosition, spawnYPosition);
                                spawnRate = 4f;
                            }
                            break;
                    }

                }
                
            }
            
            
                
            
            
        }
        else if (SorH == 1)
        {
            
            if (timeSinceLastSpawned >= spawnRate)
            {

                int CountOHouse = rand.Next(0, 4);
                for (int i = 0; i < CountOHouse; i++)
                {
                    spawnRate = 0f;
                    int chan = i;
                    timeSinceLastSpawned += Time.deltaTime+1f;
                    switch (chan)
                    {
                        case 0:
                            {
                                
                                if (timeSinceLastSpawned >= spawnRate)
                                {
                                    timeSinceLastSpawned =0f;
                                    spawnYPosition = 0.02f;
                                   float spawnXPosition = 30f;
                                    RandomsRoom(spawnXPosition, spawnYPosition);
                                    WinorDor = rand.Next(0, 2);
                                    spawnRate = 6f;
                                    if (WinorDor == 0)
                                    {
                                        Window[currentWindow].transform.position = new Vector2(spawnXPosition - 12.2f, spawnYPosition);
                                        currentWindow++;
                                        if (currentWindow >= PoolSize)
                                        {
                                            currentWindow = 0;
                                        }
                                    }
                                    else if (WinorDor == 1)
                                    {
                                        Door[currentDoor].transform.position = new Vector2(spawnXPosition - 12.2f, spawnYPosition);
                                        currentDoor++;
                                        if (currentDoor >= PoolSize)
                                        {
                                            currentDoor = 0;
                                        }
                                    }
                                    Door[currentDoor].transform.position = new Vector2(spawnXPosition + 12.2f, spawnYPosition);
                                    currentDoor++;
                                    if (currentDoor >= PoolSize)
                                    {
                                        currentDoor = 0;
                                    }

                                }


                                break;
                            }
                        case 1:
                            {
                                if (timeSinceLastSpawned >= spawnRate)
                                {
                                    timeSinceLastSpawned = 0f;
                                    spawnYPosition = 0.02f;
                                    float spawnXPosition = 30f + 24.83f;
                                    RandomsRoom(spawnXPosition, spawnYPosition);
                                    spawnRate = 8f;

                                    Door[currentDoor].transform.position = new Vector2(spawnXPosition + 12.2f, spawnYPosition);
                                    currentDoor++;
                                    if (currentDoor >= PoolSize)
                                    {
                                        currentDoor = 0;
                                    }
                                    
                                }
                                break;
                            }
                        case 2:
                            {
                                if (timeSinceLastSpawned >= spawnRate)
                                {
                                    timeSinceLastSpawned = 0f;
                                    spawnYPosition = 0.02f;
                                    float spawnXPosition = 30f + 24.83f+ 24.83f;
                                    RandomsRoom(spawnXPosition, spawnYPosition);
                                    spawnRate = 8f;
                                    WinorDor = rand.Next(0, 2);
                                    if (WinorDor == 0)
                                    {
                                        Window[currentWindow].transform.position = new Vector2(spawnXPosition + 12.2f, spawnYPosition);
                                        currentWindow++;
                                        if (currentWindow >= PoolSize)
                                        {
                                            currentWindow = 0;
                                        }
                                    }
                                    else if(WinorDor == 1)
                                    {
                                        Door[currentDoor].transform.position = new Vector2(spawnXPosition + 12.2f, spawnYPosition);
                                        currentDoor++;
                                        if (currentDoor >= PoolSize)
                                        {
                                            currentDoor = 0;
                                        }
                                    }
                                }

                                break;

                            }

                    }
                    
                }
                

            }
        }
    }
 
    public void RandomsRoom(float spXPosition, float spYPosition)
    {
            int WhatRoom = rand.Next(0, 3);
        Debug.Log(WhatRoom);
        switch (WhatRoom)
            {
                case 0:
                    {
                        Room1[currentRoom1].transform.position = new Vector2(spXPosition, spYPosition);
                        currentRoom1++;
                        if (currentRoom1 >= PoolSize)
                        {
                            currentRoom1 = 0;
                        }
                        break;
                    }
                case 1:
                    {
                        Room2[currentRoom2].transform.position = new Vector2(spXPosition, spYPosition);
                        currentRoom2++;
                        if (currentRoom2 >= PoolSize)
                        {
                            currentRoom2 = 0;
                        }
                        break;
                    }
                case 2:
                    {
                        Room3[currentRoom3].transform.position = new Vector2(spXPosition, spYPosition);
                        currentRoom3++;
                        if (currentRoom3 >= PoolSize)
                        {
                            currentRoom3 = 0;
                        }
                        break;
                    }
            }
        
        

    }
    public void RandomsBarrier(float sxp,float syp)
    {
        int WhatBarrier = rand.Next(0, 3);
        switch (WhatBarrier)
        {
            case 0:
                {
                    Box[currentBox].transform.position = new Vector2(sxp, syp);
                    currentBox++;

                    if (currentBox >= PoolSize)
                    {
                        currentBox = 0;
                    }
                    break;
                }
            case 1:
                {
                    Fence[currentFence].transform.position = new Vector2(sxp, syp);
                    currentFence++;

                    if (currentFence >= PoolSize)
                    {
                        currentFence = 0;
                    }
                    break;
                }
            case 2:
                {
                    Loader[currentLoader].transform.position = new Vector2(sxp, syp);
                    currentLoader++;

                    if (currentLoader >= PoolSize)
                    {
                        currentLoader = 0;
                    }
                    break;
                }
        }
    }
} 


