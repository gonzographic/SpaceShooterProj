using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserOne : MonoBehaviour
{
    private Vector3 myStartXPos;
    void Start()
    {
        myStartXPos = transform.position;
    }

    void Update()
    {
        transform.position += new Vector3(0, (10 * Time.deltaTime), 0);
    }
}
