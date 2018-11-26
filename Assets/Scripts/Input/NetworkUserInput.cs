using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace LavaleyGame
{
    public class NetworkUserInput : NetworkBehaviour
    {
        public NetworkPlayerController controller;

        // Update is called once per frame
        void Update()
        {
            if (isLocalPlayer)
            {
                if (controller.canMove)
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
}
