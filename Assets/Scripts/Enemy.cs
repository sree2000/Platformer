using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemySpeed = 10;
    public int xMove;
    // Start is called before the first frame update
    
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(xMove, 0));
        gameObject.GetComponent<Rigidbody2d>() > velocity = new Vector2(xMove, 0) * enemySpeed;
        if(hit.distance < 0.7f)
        {
            Flip();
            if(hit.collider.gameObject == "Player")
            {
                Destroy(hit.collider.gameObject);
            }
        }
        if(gameObject.transform.position.y < -50)
        {
            Destroy(gameObject);
        }

        void Flip()
        {
            if(xMove < 0)
            {
                xMove = -1;
            }
            else
            {
                xMove = 1;
            }
        }
    }
}
