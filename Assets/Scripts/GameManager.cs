using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Yudiz
{

    public class GameManager : MonoBehaviour
    {
        [EasyButtons.Button]
        public void StartGame()
        {
            OversManager.instance.StartOver();
        }

    }
}
