/**
    * John Shields - G00348436
    * Last Bolts Script
    * Load current amount of Bolts from PlayerPrefs
    * Display the collected Bolts from the Player's last game in Main Menu
*/

using UnityEngine;
using UnityEngine.UI;

public class lastBolts : MonoBehaviour
{
    public int bolts;

    void Start()
    {
        // load Player Bolts
        bolts = PlayerPrefs.GetInt("bolts");

        Debug.Log("Main Menu has sucessfully started");
        Debug.Log("Load Bolts from Last Game");
    }

    // display Bolt Counter
    private void OnGUI()
    {
        // find Bolt Counter - Canvas - Text
        Text boltTXT = GameObject.Find("Canvas/Text").GetComponent<Text>();
        // and add the updated Bolt amount
        boltTXT.text = "BOLTS FROM LAST GAME: " + bolts;
    }
}