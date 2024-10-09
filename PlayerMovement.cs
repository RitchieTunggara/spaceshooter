using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float maxSpeed = 5f;
    float rotSpeed = 180f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Rotate Ship

        // // Grab rotation quaternion
        // Quaternion rot = transform.rotation;
        // float z = rot.eulerAngles.z;
        // z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        // rot = Quaternion.Euler (0, 0, z);
        // transform.rotation = rot;

        // // Grab the z euler angle
        // float z = rot.eulerAngles.z;

        // // Change the z angle based on input
        // z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        // // Recreat the quaternion
        // rot = Quaternion.Euler ( 0, 0, z );

        // // Feed the quaternion into rotation
        // tranform.rotation = rot;


        //Move Ship
        Vector2 pos = transform.position;

        // Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        // pos += rot * velocity;

        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

        transform.position = pos;

        // transform.Translate ( new Vector3(0, Input.GetAxis("Vertical")* maxSpeed * Time.deltaTime), 0);
    }
}
