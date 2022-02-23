using System.Collections;


using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public Animator anim;

    public float speed = 6;
    public float gravity = -9.81f;
    public float jumpHeight = 3;
    Vector3 velocity;
    public GameObject Player;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    float turnSmoothVelocity;
    public float turnSmoothTime = 0.1f;

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Player.GetComponent<TestTriggerPlayer>().isGrounded);
        //jump
        //Player = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (Player.GetComponent<TestTriggerPlayer>().isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            
        }
    
        if (Input.GetButtonDown("Jump") && Player.GetComponent<TestTriggerPlayer>().isGrounded == true)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -8 * gravity);
            Player.GetComponent<TestTriggerPlayer>().isGrounded = false;
        }
        //gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        //walk
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        anim.SetFloat("celeraMovSpeed", horizontal);
        anim.SetFloat("celeraMovSpeed", vertical);

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetTrigger("celeraAttack");
        }

        


    }

    //void OnTriggerStay(Collider other){
    //    if(other.CompareTag("Terrain")){
    //        Player = true;
    //    }
    //}
}