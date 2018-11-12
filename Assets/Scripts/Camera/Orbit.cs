using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LavaleyGame
{
    public class Orbit : MonoBehaviour
    {
        public Transform target;    // Camera focus
        public Vector3 offset = new Vector3(0, 1f, 0);  // Offset of cam from focus
        public float maxDistance = 5f;

        [Header("Collision")]
        public bool cameraCollision = false;
        public float camRadius = 1f;
        public float rayDistance = 1000f;
        public LayerMask ignoreLayers;

        private Vector3 originalOffset;
        private float distance = 5f;

        // Use this for initialization
        void Start()
        {
            // Calculate offset of camera at start
            originalOffset = transform.position - target.position;
            //Ray distance is as loong as the magnitude of the offset
            rayDistance = originalOffset.magnitude;

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (target)
                if (cameraCollision)
                {
                    // Create ray that goes backwards from target
                    Ray camRay = new Ray(target.position, -transform.forward);
                    RaycastHit hit;
                    if (Physics.SphereCast(camRay, camRadius, out hit, rayDistance, ~ignoreLayers, QueryTriggerInteraction.Ignore))
                    {
                        distance = hit.distance;
                        //exit the function
                        return;
                    }
                }

            // Reset distance if not hitting
            distance = originalOffset.magnitude;
        }

        private void LateUpdate()
        {
            if (target)
            {
                // Convert from world to local
                Vector3 localOffset = transform.TransformDirection(offset);
                transform.position = target.position + localOffset + (-transform.forward * distance);
            }
        }

        public static float ClampAngle(float angle, float min, float max)
        {
            if (angle < -360f)
                angle += 360f;
            if (angle > 360f)
                angle -= 360f;
            return Mathf.Clamp(angle, min, max);
        }
    }
}
