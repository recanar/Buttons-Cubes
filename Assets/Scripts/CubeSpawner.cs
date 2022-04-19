using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    public GameObject cubePrefab;
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cube = Instantiate(cubePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }

        //Scale the object
        if (Input.GetKey(KeyCode.Space))
        {
            cube.transform.localScale += new Vector3(0, Time.deltaTime * speed, 0);
        }

    }
}

