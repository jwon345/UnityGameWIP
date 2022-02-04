using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform Playerbody;

    public float MouseSpeed = 100f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * MouseSpeed; 
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * MouseSpeed;

        Playerbody.Rotate(Vector3.up * mouseX);
    }
}
