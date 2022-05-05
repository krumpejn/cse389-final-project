using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "player")
        {
            UpdatingCash.bankValue += UpdatingCash.pocketValue;
            UpdatingCash.pocketValue = 0;
            PunchingDudes.bountyLevel = 0;
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
            for (int i = 0; i < enemies.Length; i++)
            {
                Destroy(enemies[i]);
            }
        }
    }
}
