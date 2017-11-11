using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDeather : MonoBehaviour {

    public int hp = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (hp <= 0)
        {
            gameObject.SetActive(false);
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        //debug = true;
        if (col.CompareTag("Bullet"))
        {
            hp--;
        }
    }
}
