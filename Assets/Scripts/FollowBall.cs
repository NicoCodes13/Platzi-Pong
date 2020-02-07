using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ball;
    public float speed;
    public float Fspeed;

    // Update is called once per frame
    void Update()
    {
        Fspeed = Random.Range((speed-0.03f),speed);
        if (ball.GetComponent<BallBehaviour>().gameStarted)
        {
            if( transform.position.y < ball.position.y)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + Fspeed);
            }else if( transform.position.y > ball.position.y){
                transform.position = new Vector2(transform.position.x, transform.position.y - Fspeed);
            }
        }
    }
}
