using UnityEngine;

namespace Yudiz
{
    public class BallSpawner : MonoBehaviour
    {

        public static BallSpawner inst;

        [SerializeField] private BallScript _ballPrefab;

        [Space(10)]
        [Header("Throw Target Position")]
        [SerializeField] private float MinX = 2f;
        [SerializeField] private float MaxX = 2f;
        [SerializeField] private float MinZ = 40f;
        [SerializeField] private float MaxZ = 40f;

        private void Awake()
        {
            inst = this;
        }

        public void SpawnBall()
        {
            BallScript ballInstance  = Instantiate(_ballPrefab, transform.position, Quaternion.identity);

            Vector3 randomPos = new Vector3(Random.Range(MinX,MaxX), 0, Random.Range(MinZ,MaxZ));

            ballInstance.Shoot(randomPos);

            OversManager.instance.ballCount--;

        }
    }
}