using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    [SerializeField] private ProjectileSO projectileData;
    [SerializeField] private Rigidbody2D myRigidbody;
    private GameObject player;

    private void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        var direction = player.transform.position - transform.position;
        myRigidbody.velocity = new Vector2(direction.x, direction.y).normalized * projectileData.GetTravelSpeed;
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
