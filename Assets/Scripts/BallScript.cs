using UnityEngine;

namespace Yudiz
{
    public class BallScript : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS

        Rigidbody _ballRigidBody;

        [SerializeField] private float _desiredBallSpeed;

        #endregion

        #region UNITY_CALLBACKS        
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS

        public void Shoot(Vector3 target)
        {
            _ballRigidBody = GetComponent<Rigidbody>();

            float desiredSpeedInMetersPerSeconds = _desiredBallSpeed * 1000.0f / 3600.0f;
            float forceMagnitude = _ballRigidBody.mass * desiredSpeedInMetersPerSeconds;

            _ballRigidBody.AddForce((target - transform.position) * forceMagnitude);
        }

        #endregion

        #region PRIVATE_FUNCTIONS
        #endregion

        #region CO-ROUTINES
        #endregion

        #region EVENT_HANDLERS
        #endregion

        #region UI_CALLBACKS
        #endregion
    }
}