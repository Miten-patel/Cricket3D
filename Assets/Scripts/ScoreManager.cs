using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager inst;

    //[SerializeField] private Player player;
    //[SerializeField] private List<Player> players = new List<Player>();
    //[SerializeField] private int oversPerPlayer;
    //[SerializeField] private int oversplayed;
    //[SerializeField] private int CurrentPlayerIndex;
    [SerializeField] private int score;

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text ballLeftText;


    private void Awake()
    {
        inst = this;
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score : " + score.ToString() ;
    }

    public void UpdateBallCountText(string ballLeft)
    {
        ballLeftText.text = "Ball Left : " + ballLeft;
    }

    void HandleNormalScores(float distance)
    {
        if (distance < 20)
        {
            score += 1;
        }
        else if (distance >= 20 && distance < 40)
        {
            score += 2;
        }
        else if (distance >= 40 && distance < 65)
        {
            score += 3;
        }
    }


}
