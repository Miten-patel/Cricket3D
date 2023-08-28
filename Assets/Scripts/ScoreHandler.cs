//using UnityEngine;

//namespace Yudiz
//{
//    public class ScoreManager : MonoBehaviour
//    {
//        //public PlayerController[] players; 

//        private int currentPlayerIndex = 0;
//        private int oversPerPlayer = 3;
//        private int currentOvers = 0;

//        private void Start()
//        {
//            StartPlayerTurn();
//        }

//        private void StartPlayerTurn()
//        {
//            //players[currentPlayerIndex].StartBatting();
//        }

//        public void EndPlayerTurn(int runsScored)
//        {
//            //players[currentPlayerIndex].EndBatting();
//            //players[currentPlayerIndex].AddRunsToScore(runsScored);

//            currentOvers++;
//            if (currentOvers >= oversPerPlayer)
//            {

//                //currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;
//                currentOvers = 0;

//                if (currentPlayerIndex == 0)
//                {

//                    CompareScores();
//                }
//            }

//            StartPlayerTurn();
//        }

//        private void CompareScores()
//        {

//            int player1Score = players[0].GetTotalScore();
//            int player2Score = players[1].GetTotalScore();

//            if (player1Score > player2Score)
//            {
//                Debug.Log("Player 1 wins!");
//            }
//            else if (player2Score > player1Score)
//            {
//                Debug.Log("Player 2 wins!");
//            }
//            else
//            {
//                Debug.Log("It's a tie!");
//            }
//        }
//    }
//}


//using System.Collections.Generic;
//using UnityEngine;

//[System.Serializable]
//public class PlayerScore
//{
//    public string playerName;
//    public int totalRuns;
//    public int totalOvers;
//}

//public class ScoreManager : MonoBehaviour
//{
//    public List<PlayerScore> playerScores = new List<PlayerScore>();

//    public void UpdateScore(string playerName, int runs, int overs)
//    {
//        PlayerScore playerScore = GetPlayerScore(playerName);
//        if (playerScore != null)
//        {
//            playerScore.totalRuns += runs;
//            playerScore.totalOvers += overs;
//        }
//        else
//        {
//            playerScores.Add(new PlayerScore
//            {
//                playerName = playerName,
//                totalRuns = runs,
//                totalOvers = overs
//            });
//        }
//    }

//    public PlayerScore GetPlayerScore(string playerName)
//    {
//        return playerScores.Find(playerScore => playerScore.playerName == playerName);
//    }
//}



//using UnityEngine;

//public class PlayerManager : MonoBehaviour
//{
//    public int totalOvers = 5;
//    public int playersCount = 2;

//    private int currentPlayerIndex = 0;
//    private int oversPlayed = 0;

//    public void SwitchPlayer()
//    {
//        currentPlayerIndex = (currentPlayerIndex + 1) % playersCount;
//        oversPlayed = 0;

//        // TODO: Handle UI to show the current player's turn
//    }

//    public void OversCompleted()
//    {
//        oversPlayed++;

//        if (oversPlayed >= totalOvers)
//        {
//            // Move to the next player's turn
//            SwitchPlayer();
//        }
//    }
//}


//public class GameManager : MonoBehaviour
//{
//    public int score = 0;

//    void HandleScoring(float distance)
//    {
//        if (distance < 10)
//        {
//            score += 1;
//        }
//        else if (distance >= 10 && distance < 20)
//        {
//            score += 2;
//        }
//        else if (distance >= 20)
//        {
//            score += 4;
//        }
//    }
//}