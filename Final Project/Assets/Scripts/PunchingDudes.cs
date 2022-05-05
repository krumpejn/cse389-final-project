using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingDudes : MonoBehaviour
{
    public static int robCount = 0;
    public static int bountyLevel = 0;
    public static float spawnInterval = 5.0f;
    public GameObject enemy;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "civilian")
        {
            UpdatingCash.pocketValue += 500;
            robCount++;
        }
        if (robCount >= 5)
        {
            if(bountyLevel < 5)
            {
                bountyLevel++;
                if (bountyLevel == 1)
                {
                    SpawnObjs(enemy, 5);
                }
                else if (bountyLevel > 1 && bountyLevel <= 5)
                {
                    SpawnObjs(enemy, 2);
                }
            }
            robCount = 0;
        }
    }

        public static IEnumerator SpawnObjs(GameObject target, int totalToSpawn)
        {
            for (int i = 0; i < totalToSpawn; i++)
            {
                Vector3 position = new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20));
                Quaternion orientation = Quaternion.Euler(0, Random.Range(0, 360), 0);
                Instantiate(target, position, orientation);
                yield return new WaitForSeconds(spawnInterval);
            }

        }
}
