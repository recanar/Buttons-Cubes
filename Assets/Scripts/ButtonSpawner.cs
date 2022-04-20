using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawner : MonoBehaviour
{
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject cube;
    void Start()
    {
        new Button(Color.red, KeyCode.A, Vector3.zero, button, cube);
        new Button(Color.green, KeyCode.S, Vector3.right, button, cube);
        new Button(Color.blue, KeyCode.D, Vector3.right*2, button, cube);
        new Button(Color.grey, KeyCode.F, Vector3.right*3, button, cube);
        new Button(Color.yellow, KeyCode.G, Vector3.right * 4, button, cube);
        new Button(Color.cyan, KeyCode.H, Vector3.right * 5, button, cube);
    }
    private class Button
    {
        Color buttonColor; //color of button
        KeyCode buttonKeyCode; //which key should be pressed to create a cube
        Vector3 buttonPosition; //button's spawn location
        GameObject button; //prefab of button
        GameObject cube; //prefab to create when key pressed 
        public Button(Color buttonColor, KeyCode buttonKeyCode, Vector3 buttonPosition, GameObject button, GameObject cube)
        {
            this.buttonColor = buttonColor;
            this.buttonKeyCode = buttonKeyCode;
            this.buttonPosition = buttonPosition;
            this.button = button;
            this.cube = cube;
            CreateButton();
        }
        private void CreateButton()
        {
            button = Instantiate(button, buttonPosition, Quaternion.identity);

            button.GetComponent<Renderer>().material.SetColor("_Color", buttonColor);//gives color to the button
            var cubeSpawnerScript = button.AddComponent<CubeSpawner>();
            cubeSpawnerScript.spawnKey = buttonKeyCode;
            cubeSpawnerScript.cubePrefab = cube;
        }
    }
}

