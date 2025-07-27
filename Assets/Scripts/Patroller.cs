using UnityEngine;

public class Patroller : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed = 4f;
    
    private int _currentWaypointIndex = 0;
    private Transform _targetWaypoint;

    private void Awake()
    {
        _targetWaypoint = _waypoints[_currentWaypointIndex];
    }
    
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetWaypoint.position, _speed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, _targetWaypoint.position) == 0)
            _targetWaypoint = _waypoints[++_currentWaypointIndex % _waypoints.Length];
    }
}
