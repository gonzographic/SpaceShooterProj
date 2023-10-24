using UnityEngine;

public class PlayScreen : MonoBehaviour
{
    [SerializeField] private AudioSource soundSource;
    [SerializeField] private AudioClip startVoice;

    void Start()
    {
        Invoke("PlaySound", 1.2f);
    }

    private void PlaySound()
    {
        soundSource.PlayOneShot(startVoice);
    }
}