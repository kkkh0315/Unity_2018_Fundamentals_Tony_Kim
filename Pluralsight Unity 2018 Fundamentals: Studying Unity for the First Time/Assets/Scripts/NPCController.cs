using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{
    public float patrolTime = 5f;
    public float aggroRange = 10f;
    public Transform[] waypoints;

    private int index;
    private float speed, agentSpeed;
    private Transform player;

    private Animator anim;
    private NavMeshAgent agent;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        if (agent != null)
        {
            agentSpeed = agent.speed;
        }

        player = GameObject.FindGameObjectWithTag("Player").transform;
        index = Random.Range(0, waypoints.Length - 1);

        InvokeRepeating("Tick", 0, 0.5f);

        if (waypoints.Length > 0)
        {
            InvokeRepeating("Patrol", 0, 0.5f);
        }
    }

    private void Update()
    {
        anim.SetFloat("Speed", agent.velocity.magnitude);
    }
    void Patrol()
    {
        if (Vector3.Distance(transform.position, waypoints[index].position) < 3)
        {
            if (index == waypoints.Length - 1) // 마지막 waypoint까지 갔으면 다시 0번째 waypoint로 가라는 명령
                index = 0;
            else                               // 마지막 waypoint까지 가기 전이라면 다음 waypoint로 가라는 명령
                index += 1;
        }
    }

    void Tick()
    {
        agent.speed = agentSpeed;
        agent.destination = waypoints[index].position;

        if (player != null && Vector3.Distance(transform.position, player.position) < aggroRange)
        {
            agent.destination = player.position;
            agent.speed = agentSpeed;
        }
    }
}
