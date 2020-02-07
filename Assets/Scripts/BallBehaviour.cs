using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public Transform paddle;
    public bool gameStarted = false;

    public Rigidbody2D rbBall;

    float posDif;
    // Start is called before the first frame update
    void Start()
    {
        posDif = paddle.position.x - transform.position.x;
    }
    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {

            transform.position = new Vector2(paddle.position.x - posDif, paddle.position.y);
            if (Input.GetMouseButtonDown(0))
            {
                
                rbBall.velocity = new Vector2(8, 8);
                gameStarted = true;
            }
        }
    }
}