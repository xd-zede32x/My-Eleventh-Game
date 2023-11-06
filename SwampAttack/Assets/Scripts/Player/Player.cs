using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(Animator))]
    
public class Player : MonoBehaviour
{
    [SerializeField] private int _playerHealth;
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Transform _shootPoint;

    private Weapon _currentWeapon;
    private Animator _playerAnimator;
    private int _currentPlayerHealth;

    public int Money { get; private set; }

    private void Start()
    {
        _currentWeapon = _weapons[0];
        _currentPlayerHealth = _playerHealth;
        _playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentWeapon.Shooting(_shootPoint);
        }
    }

    public void ApplyDamage(int damage)
    {
        _currentPlayerHealth -= damage;

        if (_currentPlayerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }


    public void AddMoney(int money)
    {
        Money += money;
    }
}