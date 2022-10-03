using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    Move move;
    public Vector3 CorretionDistance { get; set; }

    void Start()
    {
        move = GameObject.FindGameObjectWithTag("Player").GetComponent<Move>();

        CorretionDistance = new Vector3(0, 3, -10);
    }

    
    void Update()
    {
        transform.position = move.Position + CorretionDistance;
    }
}
