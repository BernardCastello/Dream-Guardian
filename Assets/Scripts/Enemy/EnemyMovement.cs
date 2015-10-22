using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth pHealth;
    EnemyHealth eHealth;
    NavMeshAgent nav;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        pHealth = player.GetComponent<PlayerHealth>();
        eHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (eHealth.currentHealth > 0 && pHealth.currentHealth > 0)
        {
            nav.SetDestination(player.position);
        }

        else
        {
            nav.enabled = false;
        }
    }
}
