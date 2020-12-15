/**
    * John Shields - G00348436
    * Player 2 Bolt Counter Script
    * Load current amount of Bolts from PlayerPrefs - Save Bolts to Player Prefs
    * Display the collected Bolts in game
*/

using UnityEngine;
using UnityEngine.UI;

public class P2boltCounter : MonoBehaviour
{
        public int P2bolts;

    void Start()
    {
        // load Player 2 Bolts
        P2bolts = PlayerPrefs.GetInt("P2bolts");
        Debug.Log("Player 2 Bolts Loaded");
    }

    void Update()
    {
        // save Bolts to Player 2
        PlayerPrefs.SetInt("P2bolts", P2bolts);
    }

    // display Player 2 Bolt Counter
    private void OnGUI()
    {
        // find Player 2 Bolt Counter - Canvas - Text
        Text boltTXT = GameObject.Find("P2canvas/Text").GetComponent<Text>();
        // and add the updated Bolt amount
        boltTXT.text = "PLAYER 2 BOLTS: " + P2bolts;
    }
}