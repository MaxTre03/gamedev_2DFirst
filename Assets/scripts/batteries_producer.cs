using UnityEngine;

public class batteries_producer : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject particles;
    public float r;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 10; i++)
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
        Instantiate(particles, randomPos, Quaternion.identity);
        Instantiate(itemPrefab, randomPos, Quaternion.identity);
    }
}
