using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yudiz
{
    public class OversManager : MonoBehaviour
    {
        public static OversManager instance;

        [SerializeField] GameObject[] stumps;

        [SerializeField] Vector3[] stumpOriginalPositions;

        public int ballCount = 6;
        [SerializeField] private int overPlayed = 0;
        [SerializeField] private int oversPerPlayer = 2;


        private void Awake()
        {
            instance = this;
        }

        private void Start()
        {
           
            ScoreManager.inst.UpdateBallCountText(ballCount.ToString());

            for (int i = 0; i < stumps.Length; i++)
            {
                stumpOriginalPositions[i] = stumps[i].transform.position;

            }

        }



        private void ResetPosition()
        {
            for (int i = 0; i < stumps.Length; i++)
            {
                stumps[i].transform.position = stumpOriginalPositions[i];
            }
        }



        public void OversState()
        {
            if (ballCount <= 0)
            {
                OverComplete();
            }
        }

        public void OverComplete()
        {
            ballCount = 6;
            overPlayed++;

            if(overPlayed > TurnManager.Instance.OversPerPlayer)
            {
                TurnManager.Instance.CurrentPlayersTurnOver();
            }
        }

        public void StartOver()
        {
            if (ballCount > 0)
            { 
                BallSpawner.inst.SpawnBall();
                ScoreManager.inst.UpdateBallCountText(ballCount.ToString());
                OversState();
                ResetPosition();
            }
        }

        public void ResetStumpsPosition()
        {
            //stumps.position = stumpsInitialPosition.position;
        }

    }
}
