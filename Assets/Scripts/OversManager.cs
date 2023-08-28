using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yudiz
{
    public class OversManager : MonoBehaviour
    {
        public static OversManager instance;


        public int ballCount = 6;
        [SerializeField] private int overPlayed = 0;
        [SerializeField] private int oversPerPlayer;


        private void Awake()
        {
            instance = this;
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
            overPlayed++;
            ballCount = 6;
        }

        public void StartOver()
        {
            if (ballCount > 0)
            { 
                BallSpawner.inst.SpawnBall();
                ScoreManager.inst.UpdateBallCountText(ballCount.ToString());
                OversState();
            }
        }

    }
}
