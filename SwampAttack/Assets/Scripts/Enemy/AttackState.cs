using UnityEngine;

[RequireComponent(typeof(Animator))]

public class AttackState : State
{
    [SerializeField] private int _enemyDamage;
    [SerializeField] private float _delay;

    private Animator _enemyAnimator;
    private float _lastAttackTime;

    private void Start()
    {
        _enemyAnimator = GetComponent<Animator>();
    }
    
    private void Update()
    {
        if (_lastAttackTime <= 0)
        {
            Attack(Target);
            _lastAttackTime = _delay;
        }

        _lastAttackTime -= Time.deltaTime;
    }

    private void Attack(Player target)
    {
        _enemyAnimator.Play("Attack");
        target.ApplyDamage(_enemyDamage);
    }   
}