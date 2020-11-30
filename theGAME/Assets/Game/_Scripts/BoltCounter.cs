using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoltCounter : MonoBehaviour
{
        public int bolts;

    void Start()
    {
        // load bolts
        bolts = PlayerPrefs.GetInt("bolts");
    }

    void Update()
    {
        // save bolts
        PlayerPrefs.SetInt("bolts", bolts);
    }

    // bolt counter
    private void OnGUI()
    {
        // display bolt counter
        Text boltTXT = GameObject.Find("Canvas/Text").GetComponent<Text>();
        boltTXT.text = "BOLTS: " + bolts;
    }
}