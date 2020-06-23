using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Obstacle;
    [SerializeField] private float SpawnInterval = 1;
    private float NextSpawn = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= NextSpawn)
        {
            NextSpawn = Time.time + SpawnInterval;
            Vector3 SpawnPos = new Vector3(Random.Range(-3,3), 0, 17.66f);

            Instantiate(Obstacle[Random.Range(0,3)], SpawnPos, Quaternion.identity);
        }
    }
}
