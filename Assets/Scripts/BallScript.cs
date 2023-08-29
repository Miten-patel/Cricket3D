using UnityEngine;

namespace Yudiz
{
    public class BallScript : MonoBehaviour
    {
        [Header("Speed Km/hr")]
        [SerializeField] private float desiredBallSpeed;

        [Space(10)]
        [Header("Force After Hitting Bat")]
        [SerializeField] private float forceAmount;

        private Rigidbody ballRigidbody;
        private bool collidedWithGround;
        private bool isLookingForBoundary;

        private void Awake()
        {
            ballRigidbody = GetComponent<Rigidbody>();
        }

        public void Shoot(Vector3 target)
        {
            float desiredSpeedInMetersPerSecond = desiredBallSpeed * 1000.0f / 3600.0f;
            float forceMagnitude = ballRigidbody.mass * desiredSpeedInMetersPerSecond;

            ballRigidbody.AddForce((target - transform.position) * forceMagnitude);
        }
        private void OnCollisionEnter(Collision collision)
        {
            BatController batController = collision.gameObject.GetComponent<BatController>();

            if (batController != null)
            {
                ballRigidbody.AddForce(Vector3.back * forceAmount, ForceMode.Impulse);
                isLookingForBoundary = true;
            }

            if (isLookingForBoundary && collision.gameObject.CompareTag("Ground"))
            {
                Debug.Log("Collided with Ground");
                collidedWithGround = true;
                isLookingForBoundary = false;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Boundary"))
            {
                if (collidedWithGround)
                {
                    Debug.Log("Four");
                    ScoreManager.inst.AddScore(4);
                }
                else
                {
                    Debug.Log("Six");
                    ScoreManager.inst.AddScore(6);
                }

                OversManager.instance.StartOver();
            }
        }
    }
}
