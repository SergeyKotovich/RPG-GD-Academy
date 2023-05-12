using System;
using UnityEngine;
using UnityEngine.AI;

public class BridgeController : MonoBehaviour
{
    
    [SerializeField] private Bridge _bridge;

    [SerializeField] private NavMeshAgent _navMeshAgent;
    
    [SerializeField] private GameObject _fire;
    
    


    private void OnTriggerEnter(Collider other)
    {
        var outLine = _navMeshAgent.GetComponent<Outline>();
        if ( other.CompareTag("Player") )
        {
            if (outLine.OutlineWidth==0)
            {
                _bridge.Break();
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _fire.SetActive(true);
        }
    }
}
