using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // このスクリプトで使う変数一覧
    private CharacterController characterController;
    //private Animator m_anim;
    private Vector3 velocity;
    [SerializeField]
    private float walkSpeed = 2f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //m_anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            velocity = Vector3.zero;

            var input = new Vector3(Input.GetAxis("L_Stick_V"), 0f, Input.GetAxis("L_Stick_H"));

            if (input.magnitude > 0f)
            {
                transform.LookAt(transform.position + input);
                velocity = transform.forward * walkSpeed;
                //m_anim.SetFloat("Speed", input.magnitude);
            }
            else
            {
                //m_anim.SetFloat("Speed", 0f);
            }
        }
        velocity.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}

