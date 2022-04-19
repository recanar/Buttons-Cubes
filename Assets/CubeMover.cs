using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Translate(Vector3.up* Time.deltaTime);
    }
}
