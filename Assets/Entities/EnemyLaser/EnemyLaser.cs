using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
  
    void Start()
    {
        
    }


    void Update()
    {
        transform.position += new Vector3(0, -0.02f, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
