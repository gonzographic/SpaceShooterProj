using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    private Vector3 myTransform;
    private float shipXPos;
    private float shipYPos;
    private float newXPos;
    private float newYPos;
    void Start()
    {
        myTransform = transform.position;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        shipXPos = Input.mousePosition.x;
        shipYPos = Input.mousePosition.y;
        Debug.Log(shipXPos);

        if (shipXPos <= (Screen.width - Screen.width) + 50)
        {
            newXPos = 50;
        }
        else if (shipXPos >= (Screen.width - 50))
        {
            newXPos = Screen.width - 50;
        }
        else
        {
            newXPos = Input.mousePosition.x;
        }
        if (shipYPos <= (Screen.height - Screen.height) + 100)
        {
            newYPos = 100;
        }
        else if (shipYPos >= (Screen.height - 400))
        {
            newYPos = Screen.height - 400;
        }
        else
        {
            newYPos = Input.mousePosition.y;
        }

        myRigidbody.position = Camera.main.ScreenToWorldPoint(new Vector3(newXPos, newYPos, -Camera.main.transform.position.z));
    }
}
