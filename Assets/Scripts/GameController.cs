using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Scrip universal para controle do game

    public int Score;

    public Text scoreText;

    public float ScorePerSecond;

    public static GameController current;


    void Start()
    {
        current = this;
        
    }

    float ScoreUpdate;

    // Update is called once per frame
    void Update()
    {
        ScoreUpdate += ScorePerSecond * Time.deltaTime;
        Score = (int)ScoreUpdate;

        scoreText.text = Score.ToString("0000");
        
    }

    public void AddScore(int value){
        ScoreUpdate += value;
    }
}
