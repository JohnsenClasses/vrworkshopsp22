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


            //RaycastHit[] hits = Physics.RaycastAll(clickRay);
            //for (int i=0;i<hits.Length;i++)
            //{

            //    Debug.Log(hits[i].transform.name);
            //    Rigidbody rb = hits[i].collider.attachedRigidbody;
            //    if(rb != null)
            //    {
            //        Enemy enemy = rb.GetComponent<Enemy>();
            //        if(enemy != null)
            //        {
            //            GameObject.Destroy(enemy.gameObject);
            //        }
            //    }

            //}

            RaycastHit hit;

            int layerMask = LayerMask.GetMask("Enemies");
            if(Physics.Raycast(clickRay,out hit, Mathf.Infinity, layerMask))
            {
                Debug.Log(hit.transform.name);
                Rigidbody rb = hit.collider.attachedRigidbody;
                if (rb != null)
                {
                    Enemy enemy = rb.GetComponent<Enemy>();
                    if (enemy != null)
                    {
                        GameObject.Destroy(enemy.gameObject);
                    }
                }
            }


        }
        
        
    }
}
