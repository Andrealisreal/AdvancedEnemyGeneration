using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{
    private Mover _mover;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }
        
    public void Initialized(Transform target)
    {
        _mover.SetTarget(target);
    }
}
