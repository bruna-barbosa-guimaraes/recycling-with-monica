using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject capitaofeio;
    public float spawnTime = 2;

    void Start()
    {
        InvokeRepeating ("addEnemy",spawnTime,spawnTime);    
    }
    void addEnemy()
    {
        float option = Random.Range (0.0f,1.0f);
        Vector2 spawnPoint;
        if (option <0.5f)
        {
             spawnPoint = new Vector2(-10,1);
        }
        else
        {
            spawnPoint = new Vector2(10,1);

        }
        Instantiate (capitaofeio, spawnPoint, Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
