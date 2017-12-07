using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childDeath : MonoBehaviour {

    public GameObject parent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (parent == null)
        {
            Destroy(parent);
        }

    }
}
