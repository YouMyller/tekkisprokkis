using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reveal : MonoBehaviour {

    public GameObject blinker;

    int looping = 0;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(Wait());
	}


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        transform.position -= new Vector3(0,20,0);
        yield return new WaitForSeconds(2);
        transform.position -= new Vector3(0, 20, 0);
        yield return new WaitForSeconds(0.2f);
        transform.position -= new Vector3(0, 20, 0);
        while (looping < 6)
        {
            yield return new WaitForSeconds(0.4f);
            blinker.transform.position += new Vector3(3, 0, 0);
            yield return new WaitForSeconds(0.4f);
            blinker.transform.position -= new Vector3(3,0,0);
            looping += 1;
        }
        blinker.transform.position -= new Vector3(0,60,0);
        transform.position -= new Vector3(0,20,0);
        yield return new WaitForSeconds(2);
        transform.position -= new Vector3(0, 20, 0);
        yield return new WaitForSeconds(0.2f);
        transform.position -= new Vector3(0, 20, 0);
        looping = 0;
        while (looping < 6)
        {
            yield return new WaitForSeconds(0.4f);
            blinker.transform.position += new Vector3(3, 0, 0);
            yield return new WaitForSeconds(0.4f);
            blinker.transform.position -= new Vector3(3, 0, 0);
            looping += 1;
        }
        blinker.transform.position -= new Vector3(0, 60, 0);
        transform.position -= new Vector3(0, 20, 0);
        yield return new WaitForSeconds(2);
        transform.position -= new Vector3(0, 20, 0);



    }

	// Update is called once per frame
	void Update () {
		
	}
}
