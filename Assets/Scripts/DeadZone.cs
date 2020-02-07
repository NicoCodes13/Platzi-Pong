using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeadZone : MonoBehaviour
{

    public Text scorePlayerText;
    public Text scoreEnemyText;

    int scorePlayerQuantity;
    int scoreEnemyQuantity;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag == "Izquierdo")
        {
            scoreEnemyQuantity++;
            updateScoreLabel(scoreEnemyText,scoreEnemyQuantity);
        }
        else if (gameObject.CompareTag("Derecho"))
        {
            scorePlayerQuantity++;
            updateScoreLabel(scorePlayerText,scorePlayerQuantity);
        }
    }

    void updateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }
}