using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    public float rotationSpeed = 10f;
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
            transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }
        
}
