using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>  このスクリプトで使う変数一覧 </summary>

    /// <summary>  CharacterController </summary>
    private CharacterController characterController;
    ///<summary> キャラクターのアニメーション </summary>
    private Animator m_anim;
    private Vector3 velocity;
    /// <summary> キャラクターの移動スピード </summary>
    [SerializeField]
    private float walkSpeed = 2f;

    //public enum Status
    //{ 
    //    Move,
    //    Avoidance,
    //    Attack,
    //    Damage
    //}

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        m_anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            velocity = Vector3.zero;

            var input = new Vector3(Input.GetAxis("L_Stick_V"), 0f, Input.GetAxis("L_Stick_H"));

            if (input.magnitude > 0f)
            {
                velocity = transform.forward * walkSpeed;
                m_anim.SetBool("Walk", true);
            }
            else
            {
                m_anim.SetBool("Walk", false);
            }
            if (Input.GetButton("RB"))
            {
                velocity = transform.forward * (walkSpeed * 2);
                m_anim.SetBool("Run", true);
            }
            else
            {
                m_anim.SetBool("Run", false);
            }
            if (Input.GetButton("A Button"))
            {
                m_anim.SetBool("Roll", true);
            }
            else
            {
                m_anim.SetBool("Roll", false);
            }
            //if (Input.GetButton("Y Button"))
            //{
            //    m_anim.SetBool("DaS",true);
            //}
            //else
            //{
            //    m_anim.SetBool("DaS", false);
            //}
        }
        
        velocity.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1));

        Vector3 moveForward = cameraForward * Input.GetAxis("L_Stick_V") + Camera.main.transform.right * Input.GetAxis("L_Stick_H");

        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }
    }
    //public void Move()
    //{
    //    if (Input.GetButton("RB"))
    //    {
    //        velocity = transform.forward * (walkSpeed * 2);
    //        m_anim.SetBool("Run", true);
    //    }
    //    else
    //    {
    //        m_anim.SetBool("Run", false);
    //    }
    //}
}


