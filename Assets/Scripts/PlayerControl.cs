using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    private Rigidbody body;
    private float startX = 0;
    public float force = 13;

	// Use this for initialization
	void Start () {

        startX = Random.Range(-3f, 3f);

        transform.position = new Vector3(startX, transform.position.y, transform.position.z);

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
