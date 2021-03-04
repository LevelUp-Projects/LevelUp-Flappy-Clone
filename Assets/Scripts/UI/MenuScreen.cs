using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScreen : MonoBehaviour
{
    public Text welcomeText;
    public InputField nameInput;
    private string playerName;

    public void SetWelcomeMessage()
    {
        playerName = nameInput.text;
        welcomeText.text = "Welcome " + playerName;
    }
    public void SetWelcomeMessage(string name)
    {
        welcomeText.text = name.Length > 0 ? "Welcome " + name : "";
    }
}
