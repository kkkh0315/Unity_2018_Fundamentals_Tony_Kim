using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    #region Singleton
    public static EnemyController instance;

    void Awake()
    {
        if (instance == null)
        {
            EnemyController.instance = this;
        }
    }
    #endregion

    public float patrolTime = 5f;
    public float aggroRange = 10f;
    public float health;
    public float damage;
    public Transform[] waypoints;

    private int index;
    private float agentSpeed;
    private float InAggroRange = 0f;

    private Transform playerTrans;
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

        playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        index = Random.Range(0, waypoints.Length - 1);
        anim.SetBool("Killed", false); 
        health = 5;
        damage = 0.1f;
    }

    private void Update()
    {
        if (gameObject != null)
        {
            if (health > 0)
            {
                Tick();
                if (waypoints.Length > 0)
                {
                    Patrol();
                }
            }
            else
            {
                Die();
            }
        }
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
        if (playerTrans != null && Vector3.Distance(transform.position, playerTrans.position) < aggroRange)
        {
            agent.speed = agentSpeed * 3;
            InAggroRange = Mathf.MoveTowards(InAggroRange, 1, 0.5f * Time.deltaTime);
            anim.SetFloat("InAggroRange", InAggroRange);
            agent.destination = playerTrans.position;
        }
        else
        {
            agent.speed = agentSpeed;
            InAggroRange = Mathf.MoveTowards(InAggroRange, 0, 0.5f * Time.deltaTime);
            anim.SetFloat("InAggroRange", InAggroRange);
            agent.destination = waypoints[index].position;
        }
    }

    IEnumerator Dieaway()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }

    void Die()
    {
        anim.SetBool("Killed", true);
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        gameObject.GetComponent<Rigidbody>().AddForce(0, -180, 0);
        StartCoroutine(Dieaway());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject != null)
        {
            if (other.gameObject.tag == "Player")
            {
                anim.SetBool("Collided", true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (gameObject != null)
        {
            if (other.gameObject.tag == "Player")
            {
                anim.SetBool("Collided", false);
            }
        }
    }
}
