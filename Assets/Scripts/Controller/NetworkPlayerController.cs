using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace LavaleyGame
{
    public class NetworkPlayerController : NetworkBehaviour
    {
        [SerializeField]

        public float speed = 5f;
        public float maxVelocity = 10f;
        public Rigidbody rigid;
        public IngredientManager ingredientManager;

        public bool canMove;


        // Update is called once per frame
        void Update()
        {

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

        private void OnTriggerEnter(Collider other)
        {


            // cook according to the recipe list
            // if it's a chopping board and you press the right button
            if (other.GetComponent<Station>().name == "PrepStation" && Input.GetKeyDown("Interact"))
            {
                // chop ingredients!
                ingredientManager.ingredient.isChopped = true;
                canMove = false;
            }

            // if it's a cooking station
            if (other.GetComponent<Station>().name == "CookingStation" && Input.GetKeyDown("Interact"))
            {

            }
        }
    }
}
