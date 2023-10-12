using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject Spawner;
    public float SpawnRate = 1;
    private float timer = 0;
    public float height = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            float LowestPoint = transform.position.y - height;
            float HighestPoint = transform.position.y + height;

            Instantiate(Spawner, new Vector3(transform.position.x,Random.Range(LowestPoint,HighestPoint),0), transform.rotation);
            timer = 0;
        }
        
    }
}
