using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Transform _target;

    private void Start()
    {
        Spawn();
    }
    
    private void Spawn()
    {
        var enemy = Instantiate(_prefab);
        enemy.transform.position = transform.position;
        enemy.Initialized(_target);
    }
}
