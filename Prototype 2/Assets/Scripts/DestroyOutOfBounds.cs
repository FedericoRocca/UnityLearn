using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

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
            if(transform.position.z > topBound)
            {
                Destroy(gameObject);
            }else if(transform.position.z < lowerBound)
            {
                Debug.Log("Game over!");
                Destroy(gameObject);
            }

        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }
        
}
