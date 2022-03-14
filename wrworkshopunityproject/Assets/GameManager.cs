using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool gameStarted;
    public EnemySpawner spawner;
    //awake is called before all starts in other scripts
	private void Awake()
	{
        Debug.Log("Awake");
	}
    // Start is called before the first frame update
    void Start()
    {
        
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
        
        StartCoroutine(doGame());
    }
    public void goalScored(Goal g, Rigidbody rb)
	{
        GameObject.Destroy(rb.gameObject);
        g.setGoalAllowed(true);
	}
    IEnumerator doGame()
    {
        gameStarted = true;
        Debug.Log("Game Started");

        spawner.startSpawning(3);
        yield return null;
    }
}
