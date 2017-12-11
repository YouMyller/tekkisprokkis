using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {

    //public Sprite[] HealthSprites;

    //public Image HeartUI;

    public GameObject h1, h2, h3, h4, h5;

    public int hp = 5;

    public bool flashActive = false;

    public float flashLength;
    private float flashCounter;

    public SpriteRenderer playerSprite;

    public Transform Explosion;

    public AudioSource deathSound;

    // Use this for initialization
    void Start ()
    {
        playerSprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //HeartUI.sprite = HealthSprites[hp];

        if (hp == 4)
        {
            h5.SetActive(false);
        }
        if (hp == 3)
        {
            h4.SetActive(false);
        }
        if (hp == 2)
        {
            h3.SetActive(false);
        }
        if (hp == 1)
        {
            h2.SetActive(false);
        }
        if (hp == 0)
        {
            h1.SetActive(false);
        }

        if (flashActive)
        {
            if (flashCounter > flashLength * .66f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * .33f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if (flashCounter > 0f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
                flashActive = false;
            }
        }
        flashCounter -= Time.deltaTime;

        if (hp <= 0)
        {
            deathSound.Play();
            Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //debug = true;
        if (col.CompareTag("Bullet"))
        {
            hp--;
            flashActive = true;
            flashCounter = flashLength;
        }
        if (col.CompareTag("Child") || col.CompareTag ("Tank"))
        {
            Destroy(gameObject);
        }
    }
}
