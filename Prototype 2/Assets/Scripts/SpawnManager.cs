using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    
    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        
        try
        {
            if(Input.GetKeyDown(KeyCode.S))
            {
                int animalIndex = Random.Range(0, animalPrefabs.Length);
                Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);
            }
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }
        
}
