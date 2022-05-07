using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wander : MonoBehaviour
{
    private Bounds block1;
    private Bounds block2;
    private Bounds block3;
    private Bounds block4;
    private bool idle;
    NavMeshAgent agent;
    Animator animator;
    Transform goal;

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.speed = .75f;
        int r = Random.Range(0, 2);
        if (r == 0)
        {
            StartCoroutine(Idle());
        }
        else
        {
            StartCoroutine(Walk());
        }
        //agent.SetDestination(RandomNavSphere(agent.transform.position, 25f, -1));
    }

    void Update()
    {
        Debug.DrawLine(agent.transform.position, agent.destination);
    }

    IEnumerator Idle()
    {
        animator.SetBool("Idle", true);
        agent.isStopped = true;
        yield return new WaitForSeconds(Random.Range(5f, 10f));
        StartCoroutine(Walk());
    }

    IEnumerator Walk()
    {
        animator.SetBool("Idle", false);
        agent.isStopped = false;
        agent.SetDestination(RandomNav(agent.transform.position, 25f, -1));
        yield return new WaitForSeconds(Random.Range(10f, 15f));
        StartCoroutine(Idle());
    }

    public Vector3 RandomNav(Vector3 origin, float distance, int layermask)
    {
        Vector3 randomDirection = RandomPosition();
        randomDirection += origin;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randomDirection, out navHit, distance, layermask);
        return navHit.position;
    }

    public Vector3 RandomPosition()
    {
        Vector3 pos = Vector3.zero;
        float x, z;
        bool legal = false;
        while (!legal)
        {
            x = Random.Range(-24.0f, 24.0f);
            z = Random.Range(-13.0f, 13.0f);
            pos = new Vector3(x, 0, z);
            if (!block1.Contains(pos) &&
                !block2.Contains(pos) &&
                !block3.Contains(pos) &&
                !block4.Contains(pos))
            {
                legal = true;
            }
        }
        return pos;
    }
}
