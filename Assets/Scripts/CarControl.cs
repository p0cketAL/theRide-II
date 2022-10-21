using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarControl : MonoBehaviour
{
    // Speed
    public float MoveSpeed = 50;
    public float MaxSpeed = 15;
    private float Drag = 0.98f * 1000;
    public float SteerAngle = 20;
    public float Traction = 0.5f;
    // Acceletarion
    private Vector3 MoveForce;

    // Update is called once per frame
    void Update()
    {
        //Drag and max speed limit
        MoveForce *= Drag * Time.deltaTime;
        MoveForce = Vector3.ClampMagnitude(MoveForce, MaxSpeed);
        // Moving
        MoveForce += transform.forward * MoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position += MoveForce * Time.deltaTime;

        // Steering
        float steerInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerInput * MoveForce.magnitude * SteerAngle * Time.deltaTime);



        //Traction
        Debug.DrawRay(transform.position, MoveForce.normalized * 3);
        Debug.DrawRay(transform.position, transform.forward * 3, Color.blue);
        MoveForce = Vector3.Lerp(MoveForce.normalized, transform.forward, Traction * Time.deltaTime) * MoveForce.magnitude;



    }
}
