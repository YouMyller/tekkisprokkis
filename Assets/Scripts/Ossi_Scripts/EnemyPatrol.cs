using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {


    public Transform[] Waypoints;
    public float Speed;
    public int currentWP;
    public bool goPatrol = true;
    public Vector3 Target;
    public Vector3 MoveDirection;
    public Vector3 Velocity;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(currentWP < Waypoints.Length)
        {
            Target = Waypoints[currentWP].position;
            MoveDirection = Target - transform.position;
            Velocity = GetComponent<Rigidbody>().velocity = Velocity;

            if(MoveDirection.magnitude < 1)
            {
                currentWP++;
            }
            else
            {
                Velocity = MoveDirection.normalized * Speed;
            }
        }else
        {
            if(goPatrol)
            {
                currentWP = 0;
            }
            else
            {
                Velocity = Vector3.zero;
            }
        }
        GetComponent<Rigidbody>().velocity = Velocity;
       // transform.LookAt(Target);
    } 
}
