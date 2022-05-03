using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToBank : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Trigger entered: Add cash");
        }
    }
}