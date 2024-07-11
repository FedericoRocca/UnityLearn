using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 15.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

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
            if(transform.position.x <= -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.x >= xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime); 

            if(Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }
        
}
