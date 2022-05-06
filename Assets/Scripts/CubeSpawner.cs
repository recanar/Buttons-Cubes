using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    private GameObject cube;
    public GameObject cubePrefab;

    [HideInInspector]
    public KeyCode spawnKey;

    public float speed = 1;

    void Update()
    {
        //Spawn Cube
        if (Input.GetKeyDown(spawnKey))
        {
            cube = Instantiate(cubePrefab, transform.position+new Vector3(0,0.375f,0), Quaternion.identity);
            cube.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.SetColor("_Color", gameObject.GetComponent<Renderer>().material.color);
        }
        //Scale the Cube
        if (Input.GetKey(spawnKey))
        {
            cube.transform.localScale += new Vector3(0, Time.deltaTime * speed, 0);
        }
        //Move Cube
        if (Input.GetKeyUp(spawnKey))
        {
            cube.GetComponent<CubeMover>().MoveEnable();
        }

    }
}

