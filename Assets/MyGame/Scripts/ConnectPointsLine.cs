using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class ConnectPointsLine : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;

    private LineRenderer lineRenderer;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
    }

    private void Update()
    {
        if (pointA == null || pointB == null) return;

        lineRenderer.SetPosition(0, pointA.position);
        lineRenderer.SetPosition(1, pointB.position);
    }
}