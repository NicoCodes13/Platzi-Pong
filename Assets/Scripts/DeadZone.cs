using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Colision carnal");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Deteccion carnal");
    }
}
