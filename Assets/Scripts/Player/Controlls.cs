using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    public float MouseX { get; set; }
    public float MouseY { get; set; }
    public Vector3 Mouse { get; set; }
    public float MoveX { get; set; }
    public float MoveY { get; set; }
    public Vector3 Move { get; set; }

    void Start()
    {
        
    }

    
    void Update()
    {
        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y");
        Mouse = new Vector3(MouseX, MouseY, 0);

        MoveX = Input.GetAxis("Horizontal");
        MoveY = Input.GetAxis("Vertical");
        Move = new Vector3(MoveX, MoveY, 0);
    }
}
