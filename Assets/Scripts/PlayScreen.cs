using UnityEngine;

public class PlayScreen : MonoBehaviour
{
    [SerializeField] private AudioSource soundSource;
    [SerializeField] private AudioClip startVoice;
    [SerializeField] private AudioClip powerUp;

    void Start()
    {
        soundSource.PlayOneShot(powerUp);
        Invoke("PlaySound", 2.1f);
    }

    private void PlaySound()
    {
        soundSource.PlayOneShot(startVoice);
    }
}