using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_bomb : MonoBehaviour
{
    public GameObject itemPrefab;
    public float r;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   for (int i = 0; i < 10; i++)
        {
            spawnObject();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.B))
        ///{
         //   spawnObject();
        //}
    }

    void spawnObject()
    {
        Vector3 randomPos = Random.insideUnitCircle * r;
        Instantiate(itemPrefab, randomPos, Quaternion.identity);
    }
}
