using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject EnemyLaserPrefab;

    public GameObject explosion;
                    void Start()
                    { 
                    }

                       private void OnTriggerEnter2D(Collider2D collision)
                    {
                                        PlayerMovement.Score += 1;
                                        Destroy(gameObject);
                                        EnemyFormation.Score++;
        if (PlayerMovement.Score>5)
        {
            Application.LoadLevel("Win");
        }



                                       Instantiate(explosion, transform.position, Quaternion.identity);
                    }


                    // Update is called once per frame
                    void Update()
                    {

        if (Random.value < 0.01)
        {
            Instantiate(EnemyLaserPrefab, transform.position, Quaternion.identity);
        }

                    }
}

