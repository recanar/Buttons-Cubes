using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawner : MonoBehaviour
{
    [SerializeField] private GameObject buttons;
    [SerializeField] public GameObject button;
    Material m_Material;// = GetComponent<Renderer>().material;
    public class Button
    {
        Color buttonColor;
        KeyCode buttonKeyCode;
        Vector3 buttonPosition;
        GameObject button;

        public Button(Color buttonColor,KeyCode buttonKeyCode,Vector3 buttonPosition,GameObject button)
        {
            this.buttonColor = buttonColor;
            this.buttonKeyCode = buttonKeyCode;
            this.buttonPosition = buttonPosition;
            this.button = button;
            CreateButton();
        }
        private void CreateButton()
        {
            button=Instantiate(button, buttonPosition,Quaternion.identity);

            var buttonRenderer = button.GetComponent<Renderer>();
            buttonRenderer.material.SetColor("_Color", buttonColor);
        }
    }
    void Start()
    {
        Button button1 = new Button(Color.red, KeyCode.A, Vector3.zero, button);
        Button button2 = new Button(Color.green, KeyCode.S, Vector3.right, button);
        Button button3 = new Button(Color.blue, KeyCode.D, Vector3.right*2, button);
        Button button4 = new Button(Color.grey, KeyCode.F, Vector3.right*3, button);
    }
}
