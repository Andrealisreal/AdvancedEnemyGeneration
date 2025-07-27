using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _target;

    private void Start()
    {
        Spawn();
    }
    
    private void Spawn()
    {
        var enemy = Instantiate(_prefab);
        enemy.transform.position = transform.position;
        enemy.GetComponent<Enemy>().Initialized(_target);
    }
}
