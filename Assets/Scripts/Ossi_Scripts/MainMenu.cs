using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public bool isStart;
    public bool isCredits;
    public bool isExit;

	// Use this for initialization
	void Start () {
		
	}
    
	
	// Update is called once per frame
	void Update ()
    {

        if(Input.GetMouseButtonUp(0))
        {
            if (isStart)
            {
                print("Start the game! Yay!");
            }
            if (isCredits)
            {
                print("We made this game!");
            }
            if (isExit)
            {
                print("Please don't go :(");
            }
        }
    }
}
