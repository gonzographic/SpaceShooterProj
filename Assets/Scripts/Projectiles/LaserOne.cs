using UnityEngine;

public class LaserOne : MonoBehaviour
{
    [SerializeField] private ProjectileSO mProjectileData = null;

    private void Update()
    {
        transform.position += new Vector3(0, (mProjectileData.GetSpeed * Time.deltaTime), 0);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
