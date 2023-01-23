using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static ScoreController Instance;

    private Text scoreText;
    private static int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
    }
    public void UpdateScore()
    {
        score += 5;
        scoreText.text = score.ToString();
    }
}
