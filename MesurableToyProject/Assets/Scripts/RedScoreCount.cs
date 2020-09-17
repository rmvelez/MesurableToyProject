using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RedScoreCount : MonoBehaviour
{
    public TMP_Text scoreText;
    public int highScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision other)
    {
        // when a ball hits the hoop, the score changes and the text is updated
        if(other.gameObject.tag == "RedBall")
        {
            highScore += 1;
            scoreText.text = "Score: " + highScore.ToString();
        }
        else if(other.gameObject.tag == "BlueBall")
        {
            highScore -= 1;
            scoreText.text = "Score: " + highScore.ToString();
        }
        else if (other.gameObject.tag == "YellowBall")
        {
            highScore -= 1;
            scoreText.text = "Score: " + highScore.ToString();
        }
    }
}
