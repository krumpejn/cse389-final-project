using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownSelect : MonoBehaviour
{
    public bool targets;
    public static DropDownSelect Instance;

    public void HandleInputData(int val) 
    {
        if(val == 1)
        {
            targets = false;
        } else
        {
            targets = true;
        }
        print(targets);

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        DropDownSelect.Instance.targets = targets;
    }
}
