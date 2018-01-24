using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketScript : MonoBehaviour {

    public GameObject gameManagerObject;
    private GameManager gameManager;
    private float force;

	// Use this for initialization
	void Start () {
        gameManager = gameManagerObject.GetComponent<GameManager>();
        force = gameManager.bucketForce;
	}
	
	// Update is called once per frame
	void Update () {
        force = gameManager.bucketForce;
	}

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up*force);
        gameManager.pointsCounter++;
    }
}
