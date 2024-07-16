using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
        try
        {
            InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        try
        {

        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }

    void SpawnRandomAnimal()
    {
        try
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        catch (System.Exception ex) 
        {
            Debug.Log(ex);
            throw;
        }
    }
        
}
