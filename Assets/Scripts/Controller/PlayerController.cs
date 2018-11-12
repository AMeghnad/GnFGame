using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LavaleyGame
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]

        public float speed = 5f;
        public float maxVelocity = 10f;
        public Rigidbody rigid;

        // Update is called once per frame
        void Update()
        {
            //inputH = Input.GetAxis("Horizontal");
            //inputV = Input.GetAxis("Vertical");
            //Vector3 initPos = transform.position;
            ////transform.forward = mainCam.transform.forward;
            ////transform.localEulerAngles = new Vector3(mainCam.transform.localEulerAngles.x, mainCam.transform.localEulerAngles.y, mainCam.transform.localEulerAngles.z);

            //direction = new Vector3(inputH, gravity, inputV) * Time.deltaTime * speed;
            ////direction += mainCam.transform.forward * distance * Time.deltaTime;
            //controller.Move(direction);
            ////if (initPos == transform.position)
            ////    Debug.Log("No Movement");
        }

        public void Move(float inputH, float inputV)
        {
            // Generate direction from input
            Vector3 direction = new Vector3(inputH, 0, inputV);

            Vector3 euler = Camera.main.transform.eulerAngles;
            direction = Quaternion.Euler(new Vector3(0, euler.y, 0)) * direction;

            // Set velocity to direction
            Vector3 vel = rigid.velocity;
            vel.x = direction.x * speed;
            vel.z = direction.z * speed;
            // Apply velocity to rigidbody
            rigid.velocity = vel;
        }
    }
}
