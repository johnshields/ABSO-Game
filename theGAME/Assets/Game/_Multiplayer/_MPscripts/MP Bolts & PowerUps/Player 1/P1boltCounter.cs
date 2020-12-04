using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1boltCounter : MonoBehaviour
{
        public int P1bolts;

    void Start()
    {
        // load bolts
        P1bolts = PlayerPrefs.GetInt("P1bolts");
    }

    void Update()
    {
        // save bolts
        PlayerPrefs.SetInt("P1bolts", P1bolts);
    }

    // bolt counter
    private void OnGUI()
    {
        // display bolt counter
        Text boltTXT = GameObject.Find("Canvas/Text").GetComponent<Text>();
        boltTXT.text = "PLAYER 1 BOLTS: " + P1bolts;
    }
}