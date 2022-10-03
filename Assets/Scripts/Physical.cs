using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physical : MonoBehaviour
{
    Controlls controlls;
    public Vector3 Gravity { get; set; }
    public GameObject RayPoint { get; set; }
    public Vector3 PointPosition { get; set; }



    void Start()
    {
        controlls = GetComponent<Controlls>();
        
        RayPoint = GameObject.FindGameObjectWithTag("RayPoint");

    }

    
    void Update()
    {
        PointPosition = RayPoint.transform.position;

        if (controlls.Move.y > 0f)
        {
            Gravity = new Vector3(0, 0, 0);
        }
        
    }

    void OnTriggerEnter(Collider colliderObject)
    {
        if (colliderObject.tag == "Ground")
        {
            Gravity = new Vector3(0, 0, 0);
        }
        else if (controlls.Move.y > 0f)
        {
            Gravity = new Vector3(0, 0, 0);
        }
        else
        {
            Gravity = new Vector3(0, -1, 0);
        }
            

    }
}
