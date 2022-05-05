using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  
    public static  int Health =10;
    public static int Score = 0;

    float xmin;
    float xmax;
    public float speed = 0.2f;
    bool speedUp = false;

    public GameObject laserPrefab;
    void Start()
    {
        Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        xmin = leftmost.x;
        xmax = rightmost.x;
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.10f, 0, 0)*speed;
        }
        

         if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.position += new Vector3(0.10f, 0, 0)*speed;
        }


        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }
        
        if (Score>4)
        {
            Application.LoadLevel("Win");
        }

            float playerX = Mathf.Clamp(transform.position.x, -6, 6);
            transform.position = new Vector3(playerX, transform.position.y, transform.position.z);
        


        
            if (speedUp) speed = 0.5f;
            else speed = 0.2f;
        

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            speedUp = !speedUp;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health --;
        Debug.Log(Health);

        if (Health<0)
        {
            Application.LoadLevel("Lose");
        }
    }

}
