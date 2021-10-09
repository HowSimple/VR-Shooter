using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    GunController gunController;
    CharacterController characterController;
    public float walkSpeed = 10f;
    public float sprintModifier = 1.30f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public float viewDistance = 10f;
    public float maxViewAngle = 60f;

    public float turnSpeed = 500f;
    
    //public string[] enemyIDs;
    public Transform headPosition;
    public Vector3 velocity;


    public void Move(float speed)
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward).normalized;
        velocity = forward * speed;
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);

    }

    public bool MoveTowards(Vector3 destination, float speed)
    {
        if(true)
        {
            Vector3 pos = transform.position;

            Vector3 currentDirection = transform.forward;

            Vector3 desiredDirection = (destination - pos).normalized;
            Vector3 forward = Vector3.Scale(desiredDirection, new Vector3(1, 0, 1)).normalized;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(forward), turnSpeed * Time.deltaTime);
        }
        return true;
    }



}
