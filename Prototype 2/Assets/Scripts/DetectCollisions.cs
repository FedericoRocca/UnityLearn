using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
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

        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        try
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex);
            throw;
        }
    }

}
