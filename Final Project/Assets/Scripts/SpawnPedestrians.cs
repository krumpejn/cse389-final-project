using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnPedestrians : MonoBehaviour
{
    public GameObject male;
    public GameObject female;
    private int pedestrians = 0;
    private int maxPedestrians = 100;
    private Bounds block1;
    private Bounds block2;
    private Bounds block3;
    private Bounds block4;

    // Start is called before the first frame update
    void Start()
    {
        block1 = 
        while (pedestrians < maxPedestrians)
        {
            Vector3 pos = RandomPosition();
            if (Random.Range(0, 2) == 0)
                Instantiate(male, pos, Quaternion.identity);
            else
                Instantiate(female, pos, Quaternion.identity);
            pedestrians++;
        }
    }

    public Vector3 RandomPosition()
    {
        float x, y, z;
        bool legal = false;
        while (!legal)
        {
            x = Random.Range(-24.0f, 24.0f);
            y = 0;
            z = Random.Range(-13.0f, 13.0f);
            
        }
    }
}
