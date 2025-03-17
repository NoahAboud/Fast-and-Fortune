using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score = 1000;
    public Text scoreText;
    public bool gameOver = false;

    void Start()
    {

    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Building"))
        {

            score -= 10000;
            scoreText.text = score.ToString();

            if (score <= 0)
            {
                score = 0;
                Destroy(gameObject);
                gameOver = true;
                Debug.Log("Game Over!");
            }
            if (collision.gameObject.CompareTag("Finish"))
            {

            }
        }
    }
   
}
