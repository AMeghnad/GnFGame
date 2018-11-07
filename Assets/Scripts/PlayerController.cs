using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    [SerializeField]
    float inputH, inputV;
    float speed = 5f;
    float gravity = -1f;
    float distance = 5f;
    Vector3 direction = Vector3.zero;
    public Camera mainCam;
    // Use this for initialization
    void Start()
    {
        //mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        Vector3 initPos = transform.position;
        //transform.forward = mainCam.transform.forward;
        //transform.localEulerAngles = new Vector3(mainCam.transform.localEulerAngles.x, mainCam.transform.localEulerAngles.y, mainCam.transform.localEulerAngles.z);

        direction = new Vector3(inputH, gravity, inputV) * Time.deltaTime * speed;
        //direction += mainCam.transform.forward * distance * Time.deltaTime;
        controller.Move(direction);
        if (initPos == transform.position)
            Debug.Log("No Movement");
    }
}
