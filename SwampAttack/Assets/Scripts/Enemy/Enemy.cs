using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Player _target;
    [SerializeField] private int _enemyHealth;
    [SerializeField] private int _moneyForMurder;

    public Player Target => _target;

    public event UnityAction Dying;

    public void TakingDamage(int damage)
    {
        _enemyHealth -= damage;

        if (_enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}