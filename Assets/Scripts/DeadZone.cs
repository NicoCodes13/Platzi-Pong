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

    public SceneChanger sceneChanger;

    private void OnTriggerEnter2D(Collider2D ball)
    {
        if (gameObject.tag == "Izquierdo")
        {
            scoreEnemyQuantity++;
            updateScoreLabel(scoreEnemyText, scoreEnemyQuantity);
        }
        else if (gameObject.CompareTag("Derecho"))
        {
            scorePlayerQuantity++;
            updateScoreLabel(scorePlayerText, scorePlayerQuantity);
        }

        ball.GetComponent<BallBehaviour>().gameStarted = false;
        CheckScore();
    }

    void CheckScore()
    {
        if(scorePlayerQuantity >= 3 )
        {
            sceneChanger.ChangeSceneTo("WinScene");
        }
        else if(scoreEnemyQuantity >=3 )
        {
            sceneChanger.ChangeSceneTo("LoseScene");
        }
    }

    void updateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }
}