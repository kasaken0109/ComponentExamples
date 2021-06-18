using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    [SerializeField] GameObject m_player;
    [SerializeField] float m_stopDistance = 2f;
    NavMeshAgent navMeshAgent;
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_player)
        {
            return;
        }

        if (Vector3.Distance(transform.position,m_player.transform.position) > m_stopDistance)
        {
            navMeshAgent.SetDestination(m_player.transform.position);
        }
        else
        {
            renderer.material.color = Color.red;
        }
    }
}
