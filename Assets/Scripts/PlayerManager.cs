using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{
    //[SerializeField] private List<Player> players = new List<Player>();
    public int totalOvers = 5;
    public int playersCount = 2;

    private int currentPlayerIndex = 0;
    private int oversPlayed = 0;

    public void SwitchPlayer()
    {
        currentPlayerIndex = (currentPlayerIndex + 1) % playersCount;
        oversPlayed = 0;
    }

    public void OversCompleted()
    {
        oversPlayed++;

        if (oversPlayed >= totalOvers)
        {
            SwitchPlayer();
        }
    }
}
