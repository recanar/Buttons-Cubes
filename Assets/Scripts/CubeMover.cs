using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    private bool canMove;
    void Update()
    {
        if (canMove)
        gameObject.transform.Translate(transform.up*Time.deltaTime);
    }
    public void MoveEnable()
    {
        canMove = true;
    }
}
