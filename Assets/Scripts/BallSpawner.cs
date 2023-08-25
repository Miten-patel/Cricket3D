using UnityEngine;

namespace Yudiz
{
    public class BallSpawner : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        [SerializeField] private BallScript _ballPrefab;
        #endregion

        #region UNITY_CALLBACKS

        private void Start()
        {
            InvokeRepeating(nameof(SpawnBall), 0, 3);
        }

        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        #endregion

        #region PRIVATE_FUNCTIONS

        private void SpawnBall()
        {
            _ballPrefab = Instantiate(_ballPrefab, transform.position, Quaternion.identity);

            Vector3 randomPos = new Vector3(Random.Range(2f, -0.3f), 0, Random.Range(40, 45));
            
            _ballPrefab.Shoot(randomPos);

        }

        #endregion

        #region CO-ROUTINES
        #endregion

        #region EVENT_HANDLERS
        #endregion

        #region UI_CALLBACKS
        #endregion
    }
}