using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatingCash : MonoBehaviour
{

    public TMPro.TextMeshProUGUI inPocket;
    public static int pocketValue = 0;
    public TMPro.TextMeshProUGUI inBank;
    public static int bankValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        inPocket.text = "$" + 0;
        inBank.text = "$" + 0;
    }

    // Update is called once per frame
    void Update()
    {
        inPocket.text = "$" + pocketValue;
        inPocket.text = "$" + bankValue;
    }
}
