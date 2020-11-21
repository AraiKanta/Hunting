using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_KeyBoard : MonoBehaviour
{
    //このスクリプトで使う変数一覧

    /// <summary>  CharacterController </summary>
    private CharacterController characterController;
    ///<summary> キャラクターのアニメーション </summary>
    private Animator m_anim;
    /// <summary> キャラクターの移動スピード </summary>
    [SerializeField] private float walkSpeed = 2f;

    [SerializeField] Transform handTransform;
    [SerializeField] Transform chestTransform;
    [SerializeField] Transform katana;
    private Vector3 velocity;

    AttackAnim attackAnim;

    /// <summary>
    ///　刀プレハブの親Objectは手の空Objectとする
    /// </summary>
    public void WeaponSwitch()
    {
        katana.parent = handTransform;
        katana.localPosition = Vector3.zero;
        katana.localRotation = Quaternion.identity;
    }
    /// <summary>
    ///　刀プレハブの親Objectは背中の空オブジェクトとする
    /// </summary>
    public void SwordDelivery()
    {
        katana.parent = chestTransform;
        katana.localPosition = Vector3.zero;
        katana.localRotation = Quaternion.identity;
    }

    private enum Status
    {
        //Move,
        //Avoidance,
        Attack,
        //Damage
    }

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

            var input = new Vector3(Input.GetAxis("Vertical"), 0f, Input.GetAxis("Horizontal"));

            if (input.magnitude > 0f)
            {
                velocity = transform.forward * walkSpeed;
                m_anim.SetBool("Walk", true);
            }
            else
            {
                m_anim.SetBool("Walk", false);
            }
            if (Input.GetButton("Fire3"))
            {
                velocity = transform.forward * (walkSpeed * 2);
                m_anim.SetBool("Run", true);
            }
            else
            {
                m_anim.SetBool("Run", false);
            }
            if (Input.GetButtonDown("Jump"))
            {
                m_anim.SetBool("Roll", true);
            }
            else
            {
                m_anim.SetBool("Roll", false);
            }
            if (Input.GetMouseButtonDown(1))
            {
                m_anim.SetBool("DaS", true);
            }
            else
            {
                m_anim.SetBool("DaS", false);
            }
            if (Input.GetButtonDown("Key_G"))
            {
                m_anim.SetBool("SD", true);
            }
            else
            {
                m_anim.SetBool("SD", false);
            }
        }
        velocity.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        // カメラの向いたほうにキャラクターに力を加える
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1));
        Vector3 moveForward = cameraForward * Input.GetAxis("Vertical") + Camera.main.transform.right * Input.GetAxis("Horizontal");
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

    private void Attack() 
    {
        attackAnim = GetComponent<AttackAnim>();
    }
}


