using UnityEngine;

// make students write entire class >:3
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _playerTransform;

    public void StartChasing()
    {
        enabled = true;
    }

    public void StopChasing()
    {
        enabled = false;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            _playerTransform.position,
            _speed * Time.deltaTime
        );
    }
}