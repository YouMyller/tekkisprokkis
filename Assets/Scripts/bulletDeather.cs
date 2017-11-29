using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDeather : MonoBehaviour {

    public int hp = 3;

    SpriteRenderer sr;

    public Sprite dead;

    public Transform Explosion;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (hp <= 0)
        {
            //if (!Explosion.activeInHie)          TEE TÄMÄ
            {
                Instantiate(Explosion, transform.position, transform.rotation);
            }
            sr.sprite = dead;
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
