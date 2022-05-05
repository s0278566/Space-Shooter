using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += new Vector3(0, 0.02f, 0);

        if (transform.position.y > 16)
        {
            Destroy(gameObject);
        }
    }
}
