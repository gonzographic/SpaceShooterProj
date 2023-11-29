using UnityEngine;

public class PlayScreen : MonoBehaviour
{
    [SerializeField] private AudioSource mSoundSource = null;
    [SerializeField] private AudioClip mStartVoice = null;
    [SerializeField] private AudioClip mPowerUp = null;

    private void OnEnable()
    {
        Actions.KillCount?.Invoke(0);
        mSoundSource.PlayOneShot(mPowerUp);
        Invoke("PlaySound", 2.1f);
    }

    private void PlaySound()
    {
        mSoundSource.PlayOneShot(mStartVoice);
    }
}