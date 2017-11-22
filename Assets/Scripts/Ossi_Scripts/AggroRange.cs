﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggroRange : MonoBehaviour
{
    public GameObject player;
    public float aggroRange;
    private Ray Sight;
    public float damping;

    private Rigidbody myRigidBody;

    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Sight.origin = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Sight.direction = transform.right;
        RaycastHit hit;
        float distance = Vector3.Distance(transform.position, player.transform.position);
        Vector3 fwd = transform.TransformDirection(Vector3.right);

        if (distance < aggroRange)
        {
            /* Quaternion rotation = Quaternion.LookRotation(player.transform.position - transform.position);
             transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);*/
            Vector2 direction = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, damping * Time.deltaTime);
            if (Physics.Raycast(Sight, out hit, aggroRange))
            {
                Debug.DrawRay(Sight.origin, transform.right * aggroRange, Color.red);
                if (hit.collider.tag == "Player")
                {
                    print("Pew!");
                }
            }
        }
    }

}