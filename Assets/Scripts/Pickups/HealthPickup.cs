using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float distanceToNextWaypoint = 1;
    [SerializeField] private Transform waypoint;

    private Transform[] wayPoints;
    private int currentWaypoint;

    private void Start()
    {
        var temp = waypoint.GetComponentsInChildren<Transform>();
        wayPoints = new Transform[temp.Length - 1];

        for (int i = 2; i < temp.Length; i++)
        {
            wayPoints[i - 2] = temp[i];
        }

        currentWaypoint = 0;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentWaypoint].position, speed * Time.deltaTime);

        /*Vector3 rotation = wayPoints[currentWaypoint].position - transform.position;
        float axis = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, axis - 90);*/

        if (Vector3.Distance(transform.position, wayPoints[currentWaypoint].position) < distanceToNextWaypoint)
        {
            currentWaypoint++;

            if (currentWaypoint >= wayPoints.Length)
            {
                currentWaypoint = 0;
            }
        }
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
