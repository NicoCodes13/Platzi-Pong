using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {
    public Transform paddle;
    bool gameStarted = false;

    // Start is called before the first frame update
    void Start () {

    }
    // Update is called once per frame
    void Update () {
        if (!gameStarted) {

            float posDif = paddle.position.x - transform.position.x;
            transform.position = new Vector2 (paddle.position.x - posDif, paddle.position.y);
            if(Input.GetMouseButtonDown(0))
            {
                gameStarted = true;
            }
        }
    }
}