using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Button yourButton;

    // Use this for initialization
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);

    }

    void OnClick()
    {
        if (tag == "MenuStart")
        {
            SceneManager.LoadScene("LevelSelect");
        }

        else if (tag == "MenuCredits")
        {
            SceneManager.LoadScene("Credits");
        }

        else if (tag == "MenuExit")
        {
            print("There is no escape!");
        }

        else if (tag == "MenuBackToMenu")
        {
            SceneManager.LoadScene("MainMenu");
        }

        else if (tag == "MenuLvl1")
        {
            print("lvl1");
        }

        else if (tag == "MenuLvl2")
        {
            print("lvl2");
        }
    }
	
}
