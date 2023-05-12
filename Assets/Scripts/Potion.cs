using System;
using UnityEngine;
using UnityEngine.AI;

public class Potion : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _navMeshAgent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            var outLine = _navMeshAgent.GetComponent<Outline>();
            outLine.OutlineWidth = 2;
        }
    }
}
