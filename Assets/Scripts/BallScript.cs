using UnityEngine;

namespace Yudiz
{
    public class BallScript : MonoBehaviour
    {
        [Header("Speed Km/hr")]
        [SerializeField] private float _desiredBallSpeed;

        [Space(10)]
        [Header("Force After Hitting Bat")]
        [SerializeField] private float forceAmount;

        private Rigidbody _ballRigidBody;
        private bool collidedWithGround;
        private bool isLookingForBoundary;

        public void Shoot(Vector3 target)
        {
            _ballRigidBody = GetComponent<Rigidbody>();

            float desiredSpeedInMetersPerSeconds = _desiredBallSpeed * 1000.0f / 3600.0f;
            float forceMagnitude = _ballRigidBody.mass * desiredSpeedInMetersPerSeconds;

            _ballRigidBody.AddForce((target - transform.position) * forceMagnitude);
        }


        private void OnCollisionEnter(Collision collision)
        {

            BatController batScript = collision.gameObject.GetComponent<BatController>();

            if (batScript != null)
            {
                _ballRigidBody.AddForce(Vector3.back * forceAmount, ForceMode.Impulse);
                isLookingForBoundary = true;
            }

            if (isLookingForBoundary)
            {
                if (collision.gameObject.CompareTag("Ground"))
                {
                    Debug.Log("collided with Ground");
                    collidedWithGround = true;
                    isLookingForBoundary = false;
                }
            }
        }


        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Boundary") && collidedWithGround)
            {
                Debug.Log("four");
                ScoreManager.inst.AddScore(4);
                OversManager.instance.StartOver();
            }
            else if (other.gameObject.CompareTag("Boundary") && !collidedWithGround)
            {
                Debug.Log("Six");
                ScoreManager.inst.AddScore(6);
                OversManager.instance.StartOver();
            }
        }



    }

}