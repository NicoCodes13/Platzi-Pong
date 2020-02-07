using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ball;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (ball.GetComponent<BallBehaviour>().gameStarted)
        {
            if( transform.position.y < ball.position.y)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + Random.Range(0.1f,speed));
            }else if( transform.position.y > ball.position.y){
                transform.position = new Vector2(transform.position.x, transform.position.y - Random.Range(0.1f,speed));
            }
        }
    }
}
