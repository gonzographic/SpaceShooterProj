using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private Animator myAnimator;
    [SerializeField] private GameObject laserAmmo;
    [SerializeField] private GameObject bulletSpawnMiddle;
    [SerializeField] private GameObject bulletSpawnLeft;
    [SerializeField] private GameObject bulletSpawnRight;

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

        ChangeAnimations();

        KeepPlayerInBounds();

        ChangeWeapons();

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(laserAmmo, bulletSpawnMiddle.transform);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Instantiate(laserAmmo, bulletSpawnMiddle.transform);
            Instantiate(laserAmmo, bulletSpawnLeft.transform);
            Instantiate(laserAmmo, bulletSpawnRight.transform);
        }

        myRigidbody.position = Camera.main.ScreenToWorldPoint(new Vector3(newXPos, newYPos, -Camera.main.transform.position.z));
    }

    private void KeepPlayerInBounds()
    {
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
    }

    private void ChangeAnimations()
    {
        if (Input.GetAxis("Mouse X") <= -0.1)
        {
            myAnimator.SetLayerWeight(1, 1);
            myAnimator.SetLayerWeight(2, 0);
        }

        if (Input.GetAxis("Mouse X") >= 0.1)
        {
            myAnimator.SetLayerWeight(1, 0);
            myAnimator.SetLayerWeight(2, 1);
        }

        if (Input.GetAxis("Mouse X") == 0)
        {
            myAnimator.SetLayerWeight(0, 1);
            myAnimator.SetLayerWeight(1, 0);
            myAnimator.SetLayerWeight(2, 0);
        }
    }

    public void ChangeWeapons()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
        }
    }
}
