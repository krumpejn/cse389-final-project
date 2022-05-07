using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAround : MonoBehaviour
{
    private bool idling = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    IEnumerable RandomTimeInterval()
    {
        while (true)
        {
            float interval = Random.Range(5.0f, 20.0f);
            idling = !idling;
            yield return new WaitForSeconds(interval);
            idling = !idling;
        }
    }
}
