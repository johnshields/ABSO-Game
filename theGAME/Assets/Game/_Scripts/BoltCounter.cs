﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoltCounter : MonoBehaviour
{
    private static BoltCounter instance;
    public static BoltCounter Instance { get { return instance; } }

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
        // display bolts
        Text boltTXT = GameObject.Find("Canvas/Text").GetComponent<Text>();
        boltTXT.text = "BOLTS: " + bolts;
    }
}
