using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public float bucketForce = 1000;
    public Text pointsText;
    public GameObject playerPrefab;
    private GameObject playerInstance;

    [HideInInspector]
    public int pointsCounter = 0;

	// Use this for initialization
	void Start () {
        InstantiatePlayer();
	}

    void InstantiatePlayer()
    {
        if (playerInstance != null)
            Destroy(playerInstance);
        playerInstance = Instantiate(playerPrefab, new Vector3(0, 19, -3), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Pause"))
        {
            PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            UnpauseGame();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
        }

        pointsText.text = "Points: " + pointsCounter;
	}

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
    }

    public void ResetGame()
    {
        pointsCounter = 0;
        pointsText.text = "Points: " + pointsCounter;
        InstantiatePlayer();
        UnpauseGame();
    }
}
