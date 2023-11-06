using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _bulletDamage;
    [SerializeField] private float _bulletSpeed;

    private void Update()
    {
        transform.Translate(Vector2.left * _bulletSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakingDamage(_bulletDamage);
            Destroy(gameObject);
        }
    }
}