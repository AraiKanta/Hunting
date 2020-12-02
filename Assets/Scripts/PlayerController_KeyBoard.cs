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

    //AttackAnim attackAnim;

    /// <summary>
    ///　刀プレハブの親Objectは手の空Objectとする(抜刀)
    /// </summary>
    public void WeaponSwitch()
    {
        katana.parent = handTransform;
        katana.localPosition = Vector3.zero;
        katana.localRotation = Quaternion.identity;
    }
    /// <summary>
    ///　刀プレハブの親Objectは背中の空オブジェクトとする(納刀)
    /// </summary>
    public void SwordDelivery()
    {
        katana.parent = chestTransform;
        katana.localPosition = Vector3.zero;
        katana.localRotation = Quaternion.identity;
    }

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        m_anim = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
        Avoidance();
        DasSd();
        Attack();
        //Damage();
    }
    void Move()
    {
        if (characterController.isGrounded)
        {
            velocity = Vector3.zero;

            var input = new Vector3(Input.GetAxis("Vertical"), 0f, Input.GetAxis("Horizontal"));

            //歩く
            if (input.magnitude > 0f)
            {
                velocity = transform.forward * walkSpeed;
                m_anim.SetBool("Walk", true);
            }
            else
            {
                m_anim.SetBool("Walk", false);
            }
            //走る
            if (Input.GetButton("Fire3"))
            {
                velocity = transform.forward * (walkSpeed * 2);
                m_anim.SetBool("Run", true);
            }
            else
            {
                m_anim.SetBool("Run", false);
            }
        }
        velocity.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
    void Avoidance()
    {
        //回避
        if (Input.GetButtonDown("Jump"))
        {
            m_anim.SetBool("Roll", true);
        }
        else
        {
            m_anim.SetBool("Roll", false);
        }
    }
    void DasSd()
    {
        //抜刀
        if (Input.GetMouseButtonDown(1))
        {
            m_anim.SetBool("DaS", true);
        }
        else
        {
            m_anim.SetBool("DaS", false);
        }
        //納刀
        if (Input.GetButtonDown("Key_G"))
        {
            m_anim.SetBool("SD", true);
        }
        else
        {
            m_anim.SetBool("SD", false);
        }
    }
    void Attack() 
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    m_anim.SetBool("Attack", true);
        //}
        //else 
        //{
        //    m_anim.SetBool("Attack",false);
        //}
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
}


