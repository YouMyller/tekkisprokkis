using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childFlashing : MonoBehaviour {

    public float flashLength;
    private float flashCounter;

    public SpriteRenderer childSprite;

    // Use this for initialization
    void Start ()
    {
        //GameObject parentObject = GameObject.Find("Player");
        //playerHealth parentScript = parentObject.GetComponent<playerHealth>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject parentObject = GameObject.Find("Player");
        playerHealth parentScript = parentObject.GetComponent<playerHealth>();

        if (parentScript.flashActive == true)
        {
            if (flashCounter > flashLength * .66f)
            {
                childSprite.color = new Color(childSprite.color.r, childSprite.color.g, childSprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * .33f)
            {
                childSprite.color = new Color(childSprite.color.r, childSprite.color.g, childSprite.color.b, 1f);
            }
            else if (flashCounter > 0f)
            {
                childSprite.color = new Color(childSprite.color.r, childSprite.color.g, childSprite.color.b, 0f);
            }
            else
            {
                childSprite.color = new Color(childSprite.color.r, childSprite.color.g, childSprite.color.b, 1f);
                parentScript.flashActive = false;
            }
        }
        flashCounter -= Time.deltaTime;
        flashCounter = flashLength;
    }
}
