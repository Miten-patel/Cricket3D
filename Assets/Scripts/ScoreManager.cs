using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager inst;

    public List<Player> players = new List<Player>();
    public Player player;

    [SerializeField] private int numberofPlayer;

    [Header("Current Player Stats")]
    [SerializeField] private string currentplayerName;
    [SerializeField] private int currentPlayerScore;
    [SerializeField] private int currentPlayersBallLeft;
    [SerializeField] private int currentOverLeft;
    [SerializeField] private int currentPlayerIndex;


    [Header("Texts Updates")]
    [SerializeField] private TMP_Text currentPlayerscoreText;
    [SerializeField] private TMP_Text currentPlayerballLeftText;
    [SerializeField] private TMP_Text currentPLayerNameText;
    [SerializeField] private TMP_Text currentOverLeftText;

    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {
        //for (int i = 0; i < numberofPlayer; i++)
        //{
        //    //players.Add(new Player);
        //}
    }

    public void AddScore(int scoreToAdd)
    {
        Debug.Log("Score Added");
        players[currentPlayerIndex].totalRuns += scoreToAdd;
        currentPlayerScore = players[currentPlayerIndex].totalRuns;

        currentPlayerscoreText.text = "Score : " + currentPlayerScore.ToString();
    }


    public void UpdateBallCountText(string ballLeft)
    {
        currentPlayerballLeftText.text = "Ball Left : " + ballLeft;
    }

    void HandleNormalScores(float distance)
    {
        if (distance < 20)
        {
            currentPlayerScore += 1;
        }
        else if (distance >= 20 && distance < 40)
        {
            currentPlayerScore += 2;
        }
        else if (distance >= 40 && distance < 65)
        {
            currentPlayerScore += 3;
        }
    }
}

[System.Serializable]
public class Player
{
    public string playerName;
    public int totalRuns;
    public int totalBoundaries;
    public int totalSixes;
    public int totalFours;
}
