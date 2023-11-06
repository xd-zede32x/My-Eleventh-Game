using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements.Experimental;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _enemyHealth;
    [SerializeField] private int _moneyForMurder;

    private Player _target;

    public Player Target => _target;
    public int Reward => _moneyForMurder;

    public event UnityAction<Enemy> Dying;

    public void Init(Player target)
    {
        _target = target;
    }

    public void TakingDamage(int damage)
    {
        _enemyHealth -= damage;

        if (_enemyHealth <= 0)
        {
            Dying?.Invoke(this);
            Destroy(gameObject);
        }
    }
}