using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDoor : MonoBehaviour {

    public GameObject triggerObject;
    public float speed = .1f;
    public float moveTime = 1f;
    //public int moveup, movedown, moveright, moveleft;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (!triggerObject.active)
        {
            moveTime -= Time.deltaTime;
            if (moveTime >= 0)
            {
                transform.Translate(Vector2.up * speed);
            }
            if (moveTime <= 0)
            {
                Destroy(gameObject);
            }
        }
	}
}
