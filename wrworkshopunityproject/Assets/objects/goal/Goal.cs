using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameManager manager;
    bool goalAllowed = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OnTriggerEnter(Collider other)
	{

        if(other.attachedRigidbody == null) { return;  }
        Debug.Log(other.name + " entered goal");
        goalAllowed = false;
        manager.goalScored(this, other.attachedRigidbody);
        
	}
	public void OnTriggerExit(Collider other)
	{
        if (other.attachedRigidbody == null) { return; }
        Debug.Log(other.name + " exited");
	}
	public void OnTriggerStay(Collider other)
	{
        if (other.attachedRigidbody == null) { return; }
        Debug.Log(other.name + " inside");
	}
    public void setGoalAllowed(bool allowed)
	{
        goalAllowed = allowed;
	}
}
