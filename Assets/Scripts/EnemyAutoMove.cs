using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAutoMove : MonoBehaviour
{
    public Transform centrel;

    private NavMeshAgent m_agent;

    [Header("ランダムで決める数値の最小")]
    [SerializeField] float radiusS = 1;
    [Header("ランダムで決める数値の最大")]
    [SerializeField] float radiusR = 10;
    [Header("待機時間")]
    [SerializeField] float waitTime = 3;
    [Header("待機時間を数える")]
    [SerializeField] float time = 0;

    Animator m_anim;
    Vector3 pos;

    void Start()
    {
        m_agent = GetComponent<NavMeshAgent>();
        m_anim = GetComponent<Animator>();

        m_agent.autoBraking = false;
        m_agent.updateRotation = false;

        GotoNextPoint();
    }
    void GotoNextPoint() 
    {
        m_agent.isStopped = false;
        float posX = Random.Range(radiusS, radiusR);
        float posZ = Random.Range(radiusS, radiusR);

        pos = centrel.position;
        pos.x += posX;
        pos.z += posZ;

        Vector3 directionY = new Vector3(pos.x, transform.position.y, pos.z);

        Quaternion rotation = Quaternion.LookRotation(directionY - transform.position, Vector3.up);

        transform.rotation = rotation;
        m_agent.destination = pos;
    }
    void StopHere() 
    {
        m_agent.isStopped = true;
        time += Time.deltaTime;

        if (time > waitTime)
        {
            GotoNextPoint();
            time = 0;
        }
    }
    void Update()
    {
        if (!m_agent.pathPending && m_agent.remainingDistance < 0.5f)
        {
            StopHere();

            m_anim.SetFloat("Blend",m_agent.velocity.sqrMagnitude);
        }
    }
}
