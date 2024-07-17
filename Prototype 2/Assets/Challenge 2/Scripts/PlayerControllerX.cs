using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private TimeSpan lastDogSpawnedIn;
    private float spawnCooldown = 1.0f;

    private void Start()
    {
        lastDogSpawnedIn = DateTime.Now.TimeOfDay;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if( DateTime.Parse(DateTime.Now.TimeOfDay.ToString()).Subtract(DateTime.Parse(lastDogSpawnedIn.ToString())).TotalSeconds >= spawnCooldown)
            {
                lastDogSpawnedIn = DateTime.Now.TimeOfDay;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
            
        }
    }
}
