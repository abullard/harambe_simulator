using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading;

public class ScoreManager : MonoBehaviour {
    public const int FINAL_SCORE_MODIFIER = 1000000;
    public const int CURRENT_SCORE_MODIFIER = 1000;

    public int currentScore;
    public int finalScore;
    public int currentKids;

    public Text scoreText;
    public Text timeText;

    Timer timer;

    public void Start()
    {
        currentKids = 0;
        currentScore = 0;

        scoreText.text = "Score: " + GetCurrentScore().ToString();
    }

    public void Update()
    {
        // Start Timer
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + GetCurrentScore().ToString();
    }

    public void CalculateFinalScore()
    {
        finalScore = currentScore * FINAL_SCORE_MODIFIER;
    }

    public int GetCurrentScore()
    {
        return (currentKids * CURRENT_SCORE_MODIFIER);
    }

    public int GetCurrentKids()
    {
        return currentKids;
    }

    public int GetFinalScore()
    {
        return finalScore;
    }

    public void kidCountAdd()
    {
        currentKids++;
        UpdateScore();
    }

    public void SetKidCount(int i)
    {
        currentKids = i;
    }

    // Method Get
}