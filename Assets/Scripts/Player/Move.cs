using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Controlls controlls;
    Physical physical;

    public Vector3 Position { get; set; }
    public float Velocity { get; set; } = 0.03f;
    public Vector3 Moving { get; set; }

    void Start()
    {
        controlls = GetComponent<Controlls>();
        physical = GetComponent<Physical>();
    }

   
    void Update()
    {
        Position = transform.position;

        Moving = (controlls.Move + physical.Gravity) * Velocity;
        transform.position += Moving;
    }
}
