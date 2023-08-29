using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Yudiz
{
    public class TurnManager : MonoBehaviour
    {
        public static TurnManager Instance;

        public Player player;
        public List<Player> players = new List<Player>();

        public InputField Player1Name;
        public InputField Player2name;
        public InputField oversInputField;

        public int OversPerPlayer;
        public int currentPlayerIndex = 0;
        private int currentOver = 0;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {

            //OversPerPlayer = int.Parse(oversInputField.text);

        }

        public void StartGame()
        {
            //int numberOfPlayers = int.Parse(playerInputField.text);
            //totalOvers = int.Parse(oversInputField.text);

            //players[0].SetPlayerName(Player1Name.text);
            //players[1].SetPlayerName(Player2name.text);
            //InitializeGame(2);
        }


        public void SetPlayersData()
        {
            ScoreManager.inst.players[0].playerName = Player1Name.text;
            ScoreManager.inst.players[1].playerName = Player2name.text;

            OversPerPlayer = int.Parse(oversInputField.text);
            //players[0].SetPlayerName(Player1Name.text);
            //players[1].SetPlayerName(Player2name.text);
        }

        public void InitializeGame()
        {
            //oversInputField.text = OversPerPlayer.ToString();

            SetPlayersData();
            //for (int i = 0; i < numberOfPlayers; i++)
            //{
            //    players.Add(new Player { playerName = "Player " + (i + 1) });
            //}

            //ScoreManager.inst.SetTotalOvers(totalOvers);

        }




        public void CurrentPlayersTurnOver()
        {
            StartNextPlayerTurn();
        }

        public void StartNextPlayerTurn()
        {
            //currentPlayerIndex++;

            //if (currentPlayerIndex >= players.Count)
            //{
            //    currentPlayerIndex = 0;
            //    currentOver++;

            //    if (currentOver >= totalOvers)
            //    {
            //        Debug.Log("Game Over");
            //        return;
            //    }
            //}

            //Debug.Log("Starting turn for " + players[currentPlayerIndex].playerName);
        }


    }
}


//[System.Serializable]
//public class PlayerData
//{
//    public string playerName;
//    public int totalRuns;
//    public int totalBoundaries;
//    public int totalSixes;
//    public int totalFours;
//}