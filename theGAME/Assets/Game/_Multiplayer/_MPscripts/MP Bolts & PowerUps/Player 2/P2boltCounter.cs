using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2boltCounter : MonoBehaviour
{
        public int P2bolts;

    void Start()
    {
        // load bolts
        P2bolts = PlayerPrefs.GetInt("P2bolts");
    }

    void Update()
    {
        // save bolts
        PlayerPrefs.SetInt("P2bolts", P2bolts);
    }

    // bolt counter
    private void OnGUI()
    {
        // display bolt counter
        Text boltTXT = GameObject.Find("P2canvas/Text").GetComponent<Text>();
        boltTXT.text = "PLAYER 2 BOLTS: " + P2bolts;
    }
}