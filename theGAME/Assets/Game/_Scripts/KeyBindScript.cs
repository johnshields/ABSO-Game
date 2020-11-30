using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class KeyBindScript : MonoBehaviour
{
    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();

    public Text up, left, right, down, jump;

    private GameObject currentKey;
    
    private Color32 normal = new Color(255, 255, 255, 0);
    private Color32 slected = new Color(155, 0, 255, 50);

    // Start is called before the first frame update
    void Start()
    {

        /*
        keys.Add("Up", KeyCode.W);
        keys.Add("Down", KeyCode.S);
        keys.Add("Left", KeyCode.A);
        keys.Add("Right", KeyCode.D);
        keys.Add("Jump", KeyCode.Space);
        */

        // taking the PlayerPrefs and loading it. Getting a string called "Up" (default = "W") and returns what key the player has saved
        keys.Add("Up",(KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Up", "W")));
        keys.Add("Down", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Down", "S")));
        keys.Add("Left", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left", "A")));
        keys.Add("Right", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right", "D")));
        keys.Add("Jump", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Jump", "Space")));

        up.text = keys["Up"].ToString(); //KeyCode.W == "W"
        down.text = keys["Down"].ToString();
        left.text = keys["Left"].ToString();
        right.text = keys["Right"].ToString();
        jump.text = keys["Jump"].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keys["Up"]))
        {
            Debug.Log("Up");
        }
        if (Input.GetKeyDown(keys["Down"]))
        {
            Debug.Log("Down");
        }
        if (Input.GetKeyDown(keys["Left"]))
        {
            Debug.Log("Left");
        }
        if (Input.GetKeyDown(keys["Right"]))
        {
            Debug.Log("Right");
        }
        if (Input.GetKeyDown(keys["Jump"]))
        {
            Debug.Log("Jump");
        }
    }

	// change the key letters on the GUI
    void OnGUI()
    {
        if(currentKey != null)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                keys[currentKey.name] = e.keyCode;
                currentKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                // change key back to normal color
                currentKey.GetComponent<Image>().color = normal;
                currentKey = null;
            }
        }
    }

	// change the control keys
    public void ChangeKey(GameObject clicked)
    {
        if (currentKey != null)
        {
            currentKey.GetComponent<Image>().color = normal;
        }
		//change color of key when changed
        currentKey = clicked;
        currentKey.GetComponent<Image>().color = slected;
    }

    // reset keys to default
    public void DefaultKeys()
    {
        PlayerPrefs.DeleteAll();
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainOptions");
        AudioListener.volume = 1f;
    }

    // save control changes and return to options
    // note may only work on an actual build of the game
    public void SAVEandReturn()
    {
        foreach (var key in keys)
        {
            PlayerPrefs.SetString(key.Key, key.Value.ToString());
        }
        PlayerPrefs.Save();
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainOptions");
        AudioListener.volume = 1f;
    }
}