using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform Area;
    public float AreaRadius = 25f;
    public float WaitTime = 1f;

    private Animator animator;
    private NavMeshAgent Agent;
    private bool isWating = false;
    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        setRandomPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (isWating || Agent.pathPending) return;
         {
            if (Agent.remainingDistance <= Agent.stoppingDistance)
            {
                StartCoroutine(WBNM());
            }
         }
        animator.SetFloat("Speed", Agent.velocity.magnitude);
    }
    void setRandomPoint()
    {
        Vector3 RandomOffset = Random.insideUnitSphere * AreaRadius;
        RandomOffset.y = 0;
        Vector3 RandomPosition = Area.position + RandomOffset;

        NavMeshHit hit;
        if (NavMesh.SamplePosition(RandomPosition, out hit, AreaRadius, NavMesh.AllAreas)) 
        {
            Agent.SetDestination(hit.position);
            Agent.speed = 3.5f;
        }

    }
    //WBNM = Wait Before Next Move
    System.Collections.IEnumerator WBNM()
    {
        isWating = true;
        Agent.speed = 0f;
        animator.SetFloat("Speed", 0f);
        yield return new WaitForSeconds(WaitTime);
        setRandomPoint();
        isWating=false;
    }
    private void OnDrawGizmos()
    {
        if (Area != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(Area.position, AreaRadius);   
        }
    }
}
