using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_01 : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * Time.deltaTime);
    }

    
    private void OnTriggerExit2D(Collider2D col)
    {
        // Exit the world
        if (col.gameObject.layer == 6)
        {
            Destroy(gameObject);
        }
    }

    
}
