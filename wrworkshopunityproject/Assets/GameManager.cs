using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool gameStarted;
	
    //awake is called before all starts in other scripts
	private void Awake()
	{
        Debug.Log("Awake");
	}
    // Start is called before the first frame update
    void Start()
    {
        gameStarted = false;
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
    }

    // Late Update is called after all other updates in all scripts
	private void LateUpdate()
	{
        //Debug.Log("LateUpdate");
	}
    public void startGame()
	{
        gameStarted = true;
        Debug.Log("Game Started");
	}
}
