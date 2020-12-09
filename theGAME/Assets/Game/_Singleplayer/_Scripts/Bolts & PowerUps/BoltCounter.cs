/**
    * John Shields - G00348436
    * Bolt Counter Script
    * Load current amount of Bolts from PlayerPrefs - Save Bolts to Player Prefs
    * Display the collected Bolts in game
*/

using UnityEngine;
using UnityEngine.UI;

public class BoltCounter : MonoBehaviour
{
    public int bolts;

    void Start()
    {
        // load Player Bolts
        bolts = PlayerPrefs.GetInt("bolts");
    }

    void Update()
    {
        // save Bolts to Player
        PlayerPrefs.SetInt("bolts", bolts);
    }

    // display Bolt Counter
    private void OnGUI()
    {
        // find Bolt Counter - Canvas - Text
        Text boltTXT = GameObject.Find("Canvas/Text").GetComponent<Text>();
        // and add the updated Bolt amount
        boltTXT.text = "BOLTS: " + bolts;
    }
}