using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    public GameObject player;
    public float aggroRange;
    private Ray Sight;
    public float damping;

    private bool detected;

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        Sight.origin = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Sight.direction = transform.forward;
        RaycastHit hit;
        float distance = Vector3.Distance(transform.position, player.transform.position);
        Vector3 fwd = transform.TransformDirection(Vector3.right);

        if (distance < aggroRange)
        {
            Quaternion rotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
            if (Physics.Raycast(Sight, out hit, aggroRange))
            {
                Debug.DrawRay(Sight.origin, transform.forward * aggroRange, Color.red);
                if (hit.collider.tag == "Player")
                {
                    print("Pew!");
                }
            }
        }
    }

}