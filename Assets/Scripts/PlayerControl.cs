using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    private Rigidbody body;

    public float force = 13;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();

        body.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Jump"))
        {
            body.useGravity = true;
            force = 0;
        }

        var horizontal = Input.GetAxis("Horizontal");
        //var vertical = Input.GetAxis("Vertical");

        //body.AddForce(new Vector3(horizontal * force, vertical * force, 0));
        body.AddForce(new Vector3(horizontal*force,0,0));
	}
}
