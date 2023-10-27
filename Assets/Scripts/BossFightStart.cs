using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BossFightStart : MonoBehaviour
{
    [SerializeField] private GameObject bossSpawn;
    [SerializeField] private GameObject sharkBoss;
    [SerializeField] private TurretText currentKills;
    [SerializeField] private TextMeshProUGUI turretKills;
    [SerializeField] private Light2D globalLight;
    [SerializeField] private AudioSource soundSource;
    [SerializeField] private AudioClip bossFight;
    [SerializeField] private AudioClip bossIncoming;

    private int bossCount;

    private void Start()
    {
        bossCount = 0;
    }

    private void Update()
    {
        if (currentKills.GetturretKills >= 20 && bossCount <= 0)
        {
            globalLight.color = Color.red;
            bossCount = 1;
            soundSource.PlayOneShot(bossFight);
            Invoke("SpawnBoss", 4);
        }
    }

    private void SpawnBoss()
    {

        if (!sharkBoss.activeInHierarchy && bossCount == 1)
        {
            soundSource.PlayOneShot(bossIncoming);
            sharkBoss.transform.position = bossSpawn.transform.position;
            Instantiate(sharkBoss);
            Debug.Log("Im a Shark");
        }
    }
}
