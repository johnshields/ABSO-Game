using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastBolts : MonoBehaviour
{
        public int bolts;
    void Start()
    {
        // load bolts
        bolts = PlayerPrefs.GetInt("bolts");
    }
    // bolt counter
    private void OnGUI()
    {
        // display bolt counter
        Text boltTXT = GameObject.Find("Canvas/Text").GetComponent<Text>();
        boltTXT.text = "BOLTS FROM LAST GAME: " + bolts;
    }
}