/**
    * John Shields - G00348436
    * Player 1 Bolt Counter Script
    * Load current amount of Bolts from PlayerPrefs - Save Bolts to Player Prefs
    * Display the collected Bolts in game
*/

using UnityEngine;
using UnityEngine.UI;

public class P1boltCounter : MonoBehaviour
{
        public int P1bolts;

    void Start()
    {
        // load Player 1 Bolts
        P1bolts = PlayerPrefs.GetInt("P1bolts");
        Debug.Log("Player 1 Bolts Loaded");
    }

    void Update()
    {
        // save Bolts to Player 1
        PlayerPrefs.SetInt("P1bolts", P1bolts);
    }

    // display  Player Bolt Counter
    private void OnGUI()
    {
        // find Player 1 Bolt Counter - Canvas - Text
        Text boltTXT = GameObject.Find("Canvas/Text").GetComponent<Text>();
        // and add the updated Bolt amount
        boltTXT.text = "PLAYER 1 BOLTS: " + P1bolts;
    }
}