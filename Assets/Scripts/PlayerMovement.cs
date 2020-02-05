using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint( Input.mousePosition);
        Vector2 mousePos2d = Camera.main.ScreenToWorldPoint( Input.mousePosition);

        transform.position = mousePos2d;
    }
}
