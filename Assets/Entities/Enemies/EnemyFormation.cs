using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFormation : MonoBehaviour
{
    public GameObject enemyprefab;
    private bool movingRight = true;
    public static int Score = 0;
    public float speed;
    float SpawnDely = 0.5f;


    // Start is called before the first frame update


    Transform NextFreePosition()
    {
        foreach (Transform childPositionGameObject in transform)
        {
            if (childPositionGameObject.childCount ==0)
            {
                return childPositionGameObject;
            }
        }
        return null;
    }


void SpawnEnemies()
    {
        Transform freePosition = NextFreePosition();

        if (freePosition)
        {
            GameObject enemy = Instantiate(enemyprefab, freePosition.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = freePosition;
            Invoke("SpawnEnemies", SpawnDely);
        }
    }
    
    void Start()
    {
       

            SpawnEnemies();
          }

    // Update is called once per frame
    void Update()
    {

        speed = 0.006f;

        if(transform.position.x >6)
        {
            movingRight = false;
        }

        if(transform.position.x<-6)
        {
            movingRight = true;
        }

        if (movingRight)
        {
            transform.position += new Vector3(speed, 0);
        }

        else
        {
            transform.position += new Vector3(-speed, 0);
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.DrawCube(transform.position, new Vector3(6, 6));
    }
}
