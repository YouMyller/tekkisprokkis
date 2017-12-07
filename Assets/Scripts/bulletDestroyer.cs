using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroyer : MonoBehaviour {

    private float destTime = 3;

    public AudioSource onHit;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        destTime -= Time.deltaTime;

        if (destTime <= 0)
        {
            onHit.Play();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //debug = true;
        if (col.CompareTag("KillerWall") || col.CompareTag("Enemy") || col.CompareTag("Player") || col.CompareTag("Child"))
        {
            onHit.Play();
            Destroy(gameObject);
        }
    }
}
