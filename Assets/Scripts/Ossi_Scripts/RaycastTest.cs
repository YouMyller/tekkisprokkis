using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public Transform target;

    // prints "close" if the z-axis of this transform looks
    // almost towards the target

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        if(Physics.Raycast(spotter.transform.position, spotter.transform.forward, out hit, 1000.0f))

        if (hit.collider.tag == "player")
        {
            print("There is something in front of the object!");
        }
    }
}