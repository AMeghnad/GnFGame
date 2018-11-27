using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace LavaleyGame
{
    public class NetworkPlayerController : NetworkBehaviour
    {
        [SerializeField]

        public float speed = 5f;
        public float maxVelocity = 10f;
        public Rigidbody rigid;
        public IngredientManager ingredientManager;
        private IngredientType ingredientType;
        private int[] backPackSlot;
        public GUIElement backPackSpace;

        public bool canMove;

        private void Start()
        {
            backPackSlot = new int[2];
        }

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
            if (isLocalPlayer)
            {
                // cook according to the recipe list
                // if it's a chopping board and you press the right button
                if (other.GetComponent<Station>().name == "PrepStation" && Input.GetKey("Interact"))
                {
                    // chop ingredients!
                    ingredientManager.ingredient.isChopped = true;
                    canMove = false;
                }

                // if it's a cooking station
                if (other.GetComponent<Station>().name == "CookingStation" && Input.GetKey("Interact"))
                {
                    canMove = false;
                }
                else
                {
                    canMove = true;
                }
            }
        }

        public void Interact()
        {
            for (int i = 0; i < backPackSlot.Length; i++)
            {
                if (i > backPackSlot.Length)
                {
                    i -= backPackSlot.Length;
                    Debug.Log("Cannot carry any more");
                    return;
                }
            }

            //switch (ingredientType)
            //{
            //    case IngredientType.Pineapple:

            //        break;
            //    case IngredientType.Yam:
            //        break;
            //    case IngredientType.Fish:
            //        break;
            //    default:
            //        break;
            //}
        }

        // OnTriggerStay is called once per frame for every Collider other that is touching the trigger
        private void OnTriggerStay(Collider other)
        {
            if (isLocalPlayer)
            {
                // if the other object has an ingredient attached
                if (other.GetComponent<Ingredient>())
                {
                    // if you're pressing the mouse button
                    if (Input.GetMouseButtonDown(0))
                    {
                        Interact();
                    }
                }
            }
        }
    }
}
