using UnityEngine;

public class LaserOne : MonoBehaviour
{
    [SerializeField] private AudioSource laserAudio;
    [SerializeField] private AudioClip laserSound;

    private void OnEnable()
    {
        laserAudio.PlayOneShot(laserSound);
    }
    private void Update()
    {
        transform.position += new Vector3(0, (10 * Time.deltaTime), 0);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
