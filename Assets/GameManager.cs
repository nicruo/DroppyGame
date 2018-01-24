using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public float bucketForce = 1000;
    public Text pointsText;

    [HideInInspector]
    public int pointsCounter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pointsText.text = "Points: " + pointsCounter;
	}
}
