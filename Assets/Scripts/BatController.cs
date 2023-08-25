using UnityEngine;

namespace Yudiz
{
    public class BatController : MonoBehaviour
    {
        #region PUBLIC_VARS

        Vector3 pos;

        Vector3 start;



        public float speed;
        #endregion

        #region PRIVATE_VARS

        private void Start()
        {
            //start = transform.position;
            //pos = transform.position;
        }

        private void Update()
        {
            BatInputs();
        }

        #endregion

        #region UNITY_CALLBACKS        
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        #endregion

        #region PRIVATE_FUNCTIONS

        private void BatInputs()
        {
            //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //pos = Input.mousePosition;
            //pos.z = 45;
            //pos = Camera.main.ScreenToWorldPoint(pos);
            //transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);

        }

        //function Update()
        //{
        //    //transform.position.y = 0;       //This doesn't work apparently :(

        //}

        #endregion

        #region CO-ROUTINES
        #endregion

        #region EVENT_HANDLERS
        #endregion

        #region UI_CALLBACKS
        #endregion
    }
}