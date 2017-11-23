using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour {

    public bool endGame = false;
	
	// Update is called once per frame
	void Update ()
    {
        if (endGame == true)
        {
            Debug.Log("We buried him.");
            Application.Quit();
        }
    }

    public void ChangeToScene(string sceneToChangeTo)
    {
        SceneManager.LoadScene(sceneToChangeTo);
    }
}
