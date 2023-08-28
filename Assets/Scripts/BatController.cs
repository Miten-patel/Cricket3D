using UnityEngine;

namespace Yudiz
{
    public class BatController : MonoBehaviour
    {
        public float moveSpeed = 5f;
        public float rotationSpeed = 100f;

        public float forceAmount;

        private Rigidbody rb;
        private bool isRotating = false;
        private bool rotateBack = false;
        private Quaternion initialRotation;
        private Quaternion targetRotation;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            initialRotation = transform.rotation;
            targetRotation = Quaternion.Euler(120f, 0f, 0f);
        }

        private void Update()
        {
            //MoveBatWithMouse();

            if (Input.GetMouseButtonDown(0))
            {
                StartBatRotation();
            }

            UpdateBatRotation();
        }


        private void MoveBatWithMouse()
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.transform.position.y - transform.position.y;

            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            worldMousePosition.y = transform.position.y;
            worldMousePosition.z = transform.position.z;

            Vector3 targetPosition = new Vector3(worldMousePosition.x, transform.position.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }



        //private void OnCollisionEnter(Collision collision)
        //{
        //    BallScript ballScript = collision.gameObject.GetComponent<BallScript>();

        //    if (ballScript != null)
        //    {
        //        // Calculate the direction in which to apply the force
        //        Vector3 forceDirection = collision.contacts[0].point - transform.position;
        //        forceDirection.Normalize();

        //        // Apply a force to the ball's Rigidbody
        //        Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();
        //        if (ballRigidbody != null)
        //        {
        //            ballRigidbody.AddForce(forceDirection * forceAmount, ForceMode.Impulse);
        //        }
        //    }
        //}


        private void StartBatRotation()
        {
            isRotating = true;
            rotateBack = false;
        }

        private void UpdateBatRotation()
        {
            if (isRotating)
            {
                Quaternion target;
                if (rotateBack)
                {
                    target = initialRotation;
                }
                else
                {
                    target = targetRotation;
                }

                float step = rotationSpeed * Time.deltaTime;

                transform.rotation = Quaternion.RotateTowards(transform.rotation, target, step);

                if (Quaternion.Angle(transform.rotation, target) < 0.1f)
                {
                    if (rotateBack)
                    {
                        isRotating = false;
                        rotateBack = false;
                    }
                    else
                    {
                        rotateBack = true;
                    }
                }
            }
        }

    }
}
