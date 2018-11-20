using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LavaleyGame
{
    public class UserInput : MonoBehaviour
    {
        public PlayerController controller;
        public bool canMove;

        // Update is called once per frame
        void Update()
        {
            if (canMove)
            {
                // Get input axis from Unity Input manager
                float inputH = Input.GetAxis("Horizontal");
                float inputV = Input.GetAxis("Vertical");
                // Tell player to move in those directions
                controller.Move(inputH, inputV);
            }
        }
    }
}
