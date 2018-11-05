using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    [SerializeField]
    float inputH, inputV;
    float speed = 15f;
    float gravity = -1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(inputH, gravity, inputV) * Time.deltaTime * speed;
        controller.Move(direction);
    }
}
