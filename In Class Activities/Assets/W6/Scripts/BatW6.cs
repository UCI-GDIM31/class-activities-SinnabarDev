using UnityEngine;

// make students write entire class >:3
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _player;

    public void EnableChase()
    {
        enabled = true;
    }

    public void DisableChase()
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