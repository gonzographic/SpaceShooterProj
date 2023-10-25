using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float delay = 0f;
    [SerializeField] private AudioSource playSFX;
    [SerializeField] private AudioClip explosionSound;

    private float waitTime;

    private void OnEnable()
    {
        playSFX.PlayOneShot(explosionSound);
    }

    private void Update()
    {
        waitTime += Time.deltaTime;

        if (waitTime >= delay)
        {
            gameObject.SetActive(false);
        }
    }
}
