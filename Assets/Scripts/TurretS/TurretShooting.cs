using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    [SerializeField] private TurretSO turretData;
    [SerializeField] private GameObject turretBase;
    [SerializeField] private GameObject explosion;
    
    private GameObject player;
    private float currentHealth;

    private void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Start()
    {
        currentHealth = turretData.GetHealth;
    }

    private void Update()
    {
        turretBase.transform.position -= new Vector3(0, (turretData.GetMoveSpeed * Time.deltaTime), 0);

        TargetPlayer();

        if (currentHealth <= 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            TurretDie();
        }
    }

    private void TurretDie()
    {
        turretBase.SetActive(false);
        currentHealth = turretData.GetHealth;
    }

    private void TargetPlayer()
    {
        Vector3 rotation = player.transform.position - transform.position;
        float zAxisRotation = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, zAxisRotation - 90);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            currentHealth -= 1;
            collision.gameObject.SetActive(false);
        }
    }

    private void OnBecameInvisible()
    {
        turretBase.SetActive(false);
        currentHealth = turretData.GetHealth;
    }
}
