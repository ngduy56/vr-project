using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Transform vrCamera;
    public float togAngle = 20f;
    public float speed = 3f;
    public bool moveForward;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovingPlayer();
    }
    void MovingPlayer()
    {
        if (vrCamera.eulerAngles.x >= togAngle && vrCamera.eulerAngles.x < 90)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            controller.SimpleMove(forward * speed);
        }
    }
}
