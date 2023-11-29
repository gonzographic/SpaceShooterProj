using UnityEngine;

public class ObjectMovingScript : MonoBehaviour
{
    void Update()
    {
        transform.position -= new Vector3(0, (4.2f * Time.deltaTime), 0);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
