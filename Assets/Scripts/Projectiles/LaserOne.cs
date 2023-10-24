using UnityEngine;

public class LaserOne : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0, (10 * Time.deltaTime), 0);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
