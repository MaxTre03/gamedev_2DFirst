using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_bomb : MonoBehaviour
{
    public GameObject itemPrefab;
    public float r;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(spawnObject), 0f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.B))
        ///{
         //  spawnObject();
        //}
    }

    void spawnObject()
    {
        Vector2 randomPos2D = Random.insideUnitCircle * r; // Generates random (x, z) in a circle
        float yOffset = 7f; // Change this to whatever height you want the objects to start at

        Vector3 spawnPosition = new Vector3(randomPos2D.x, yOffset, randomPos2D.y);

        Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
    }

}
