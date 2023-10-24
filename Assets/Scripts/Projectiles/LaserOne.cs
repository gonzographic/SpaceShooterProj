using UnityEngine;

public class LaserOne : MonoBehaviour
{
    [SerializeField] private ProjectileSO projectileData;

    private void Update()
    {
        transform.position += new Vector3(0, (projectileData.GetTravelSpeed * Time.deltaTime), 0);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
