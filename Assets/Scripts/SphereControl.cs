using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour {

    float count = 1;
	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");

	}
	
	// Update is called once per frame
	void Update () {
        var horizontal = Input.GetAxis("Horizontal");
        count += horizontal;
        this.transform.localScale = new Vector3(count, count, count);
	}
}
