using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
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
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }
        
}
