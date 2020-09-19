using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    private Rigidbody myBody;
    private CharacterAnimation player_Animation;
    public float walk_speed = 3f;
    public float z_Speed = 1.5f;

    private float rotation_Y = -90f;
    private float rotation_Speed = 15f;

    private void Awake() {
        myBody = GetComponent<Rigidbody>();
        player_Animation = GetComponentInChildren<CharacterAnimation>();
    }

    void Update()
    {
        RotatePlayer();
        AnimatedPlayerWalk();
    }
    private void FixedUpdate() {
        DetectMovement();
    }


    void DetectMovement() 
    {
        myBody.velocity = new Vector3(
            Input.GetAxisRaw(Axis.Horizontal_Axis) * (-walk_speed),
            myBody.velocity.y,
            Input.GetAxisRaw(Axis.Vertical_Axis) * (-z_Speed));
    }

    void RotatePlayer()
    {
        if (Input.GetAxisRaw(Axis.Horizontal_Axis) > 0)
        {
            transform.rotation = Quaternion.Euler(0f, -Mathf.Abs(rotation_Y), 0f);
        } 
        else if (Input.GetAxisRaw(Axis.Horizontal_Axis) < 0)
        {
            transform.rotation = Quaternion.Euler(0f, Mathf.Abs(rotation_Y), 0f);
        }
    }

    void AnimatedPlayerWalk()
    {
        
        if (Input.GetAxisRaw(Axis.Horizontal_Axis) != 0 || 
            Input.GetAxisRaw(Axis.Vertical_Axis) != 0)
        {
            player_Animation.Walk(true);
            
        }
        else
        {
            player_Animation.Walk(false);
        }
    }
 
}
