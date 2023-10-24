using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    private GameObject player;

    private void OnEnable()
    {
        //player = GameObject.Find("PlayerShip");
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        Vector3 rotation = player.transform.position - transform.position;
        float zAxisRotation = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, zAxisRotation - 90);
    }
}
