using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorScript : MonoBehaviour {

    public GameObject gameManagerObject;
    private GameManager gameManager;

	// Use this for initialization
	void Start () {
        gameManager = gameManagerObject.GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        gameManager.PauseGame();
    }
}
