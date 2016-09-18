using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading;

public class ScoreManager : MonoBehaviour {
    public const int CURRENT_SCORE_MODIFER = 10000;

    public int currentScore;
    public int currentKids;

    public Text scoreText;
    int lifeCount = 0;

    public void Start()
    {
        currentKids = 0;
        currentScore = 0;

        scoreText.text = "Score: " + GetCurrentScore().ToString();
    }

    public void Update()
    {
        scoreText.text = "Score: " + GetCurrentScore().ToString();
    }

    public int GetCurrentScore()
    {
        return (currentKids * CURRENT_SCORE_MODIFER);
    }

    public int GetCurrentKids()
    {
        return currentKids;
    }

    public void kidCountAdd()
    {
        currentKids++;
    }

    public void Hit()
    {
        lifeCount += 1;

        if (lifeCount > 3)
            Application.LoadLevel("FailScreen");

    }
}