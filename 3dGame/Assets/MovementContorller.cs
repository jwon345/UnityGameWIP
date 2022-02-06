using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementContorller : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 10;

    public Transform camera;


    // Update is called once per frame
    void Update()
    {
        float horziontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 Direction = new Vector3(horziontal, 0,  vertical).normalized;

        if (Direction.magnitude > 0.01)
        {
            float directionAndCam = Mathf.Atan2(horziontal, vertical) * Mathf.Rad2Deg + camera.eulerAngles.y;
            //float Angle = 

            Vector3 MoveWcamera = Quaternion.Euler(0, directionAndCam, 0) * Vector3.forward;
            characterController.Move(MoveWcamera * speed * Time.deltaTime);
        }
    }
}
