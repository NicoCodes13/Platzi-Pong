using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Start is called before the first frame update
    SpriteRenderer playerSpriteRender;
    void Start () {
        playerSpriteRender = GetComponent<SpriteRenderer> (); //*trae la info del render 
    }
    // Update is called once per frame
    void Update () {
        Vector2 mousePos2d = Camera.main.ScreenToWorldPoint (Input.mousePosition);

        transform.position = new Vector2 (transform.position.x, Mathf.Clamp (mousePos2d.y,-3.9f,3.9f));
    }
}