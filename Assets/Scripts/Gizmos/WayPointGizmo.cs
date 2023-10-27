using Unity.VisualScripting;
using UnityEngine;

public class WayPointGizmo : MonoBehaviour
{
    [SerializeField] private float size = 1;

    private Transform[] wayPoints;

    private void OnDrawGizmos()
    {
        wayPoints = GetComponentsInChildren<Transform>();
        var last = wayPoints[wayPoints.Length - 1].position;

        for(int i = 1; i < wayPoints.Length; i++)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(wayPoints[i].position, size);
            Gizmos.DrawLine(last, wayPoints[i].position);
            last = wayPoints[i].position;
        }
    }
}
