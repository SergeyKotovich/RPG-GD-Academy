using System;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] private Chest _chest;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _chest.Open();
        }
    }
}
