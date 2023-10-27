using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayScreen : MonoBehaviour
{
    [SerializeField] private AudioSource soundSource;
    [SerializeField] private AudioClip startVoice;
    [SerializeField] private AudioClip powerUp;

    private void OnEnable()
    {
        Actions.KillCount?.Invoke(0);
        soundSource.PlayOneShot(powerUp);
        Invoke("PlaySound", 2.1f);
    }

    /*void Start()
    {
        soundSource.PlayOneShot(powerUp);
        Invoke("PlaySound", 2.1f);
    }*/


    private void PlaySound()
    {
        soundSource.PlayOneShot(startVoice);
    }
}