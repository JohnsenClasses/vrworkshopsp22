using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera myCamera;
    // Start is called before the first frame update
    void Start()
    {
        myCamera = transform.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickPoint = Input.mousePosition;
            Ray clickRay = myCamera.ScreenPointToRay(clickPoint);

            if (Physics.Raycast(clickRay))
            {
                Debug.Log("hit something");
            }
        }
        
        
    }
}
