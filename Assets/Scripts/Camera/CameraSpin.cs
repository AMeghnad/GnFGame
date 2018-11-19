using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LavaleyGame
{
    public class CameraSpin : MonoBehaviour
    {

        public Transform target;
        public Camera cam;
        public float str;
        void Start()
        {
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            cam = Camera.main;
        }
        void Update()
        {

            Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, str);

        }
    }
}
