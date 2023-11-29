using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private AudioSource mPlaySFX = null;
    [SerializeField] private AudioClip mExplosionSound = null;
    [SerializeField] private float mDelay = 0.0f;

    private float mWaitTime;

    private void OnEnable()
    {
        mPlaySFX.PlayOneShot(mExplosionSound);
    }

    private void Start()
    {
        mWaitTime = 0.0f;
    }

    private void Update()
    {
        mWaitTime += Time.deltaTime;

        if (mWaitTime >= mDelay)
        {
            gameObject.SetActive(false);
        }
    }
}
