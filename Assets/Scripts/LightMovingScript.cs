using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovingScript : MonoBehaviour
{
    void Update()
    {
        transform.position -= new Vector3(0, (4.2f * Time.deltaTime), 0);
    }
}
