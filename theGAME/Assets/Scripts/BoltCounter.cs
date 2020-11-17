using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoltCounter : MonoBehaviour
{
    public int bolts = 0;

    // bolt counter
    private void OnGUI()
    {

        Text boltTXT = GameObject.Find("Canvas/Text").GetComponent<Text>();
        boltTXT.text = "BOLTS: " + bolts;

    } 
}
