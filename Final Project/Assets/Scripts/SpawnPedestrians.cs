using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnPedestrians : MonoBehaviour
{
    public GameObject pedestrian;
    private int pedestrians = 0;
    private int maxPedestrians = 100;
    private Bounds floorBounds;

    // Start is called before the first frame update
    void Start()
    {

        floorBounds = GameObject.Find("Floor").GetComponent<Renderer>().bounds;
        while (pedestrians < maxPedestrians)
        {
            Vector3 point;
            RandomPosition(out point);
            Instantiate(pedestrian, point, Quaternion.identity);
            pedestrians++;
        }
    }

    public bool RandomPosition(out Vector3 result)
    {
        float rx = Random.Range(floorBounds.min.x, floorBounds.max.x);
        float rz = Random.Range(floorBounds.min.z, floorBounds.max.z);
        Vector3 randomPoint = new Vector3(rx, 0, rz);
        NavMeshHit hit;

        result = Vector3.zero;
        while (!NavMesh.SamplePosition(randomPoint, out hit, Mathf.Infinity, NavMesh.AllAreas))
        {
            rx = Random.Range(floorBounds.min.x, floorBounds.max.x);
            rz = Random.Range(floorBounds.min.z, floorBounds.max.z);
            randomPoint = new Vector3(rx, 0, rz);
        }
        result = hit.position;
        return true;
    }
}
