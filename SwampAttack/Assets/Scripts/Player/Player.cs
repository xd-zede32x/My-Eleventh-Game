using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(Animator))]
    
public class Player : MonoBehaviour
{
    [SerializeField] private int _playerHealth;
    [SerializeField] private    List<Weapon> _weapons;
    [SerializeField] private Transform _shootPoint;

    private Animator _animator;
    private Weapon _currentWeapon;
    private int _currentPlayerHealth;

    private void Start()
    {
        _currentWeapon = _weapons[0];
        _currentPlayerHealth = _playerHealth;
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentWeapon.Shooting(_shootPoint);
        }
    }
}