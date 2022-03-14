using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody rb;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            return;
        }
        Vector3 between = target.transform.position - this.transform.position;
        //do the movement
        rb.AddForce(between);
    }
    public void setTarget(GameObject target)
	{
        this.target = target;
	}
}
