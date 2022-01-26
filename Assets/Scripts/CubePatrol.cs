using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePatrol : MonoBehaviour
{
    [SerializeField]
    private Vector3 StartPosition;
    [SerializeField]
    private Vector3 EndPosition;
    [SerializeField]
    private float Speed = 1f;

    private bool MovingToEnd = true;

    private void Update()
    {
        if (MovingToEnd)
        {
            transform.Translate((EndPosition - transform.position).normalized * Speed);
            if (Vector3.Distance(transform.position, EndPosition) < 0.5f)
            {
                MovingToEnd = false;
            }
        }
        else
        {
            transform.Translate((StartPosition - transform.position).normalized * Speed);
            if (Vector3.Distance(transform.position, StartPosition) < 0.5f)
            {
                MovingToEnd = true;
            }
        }
        
    }
}
