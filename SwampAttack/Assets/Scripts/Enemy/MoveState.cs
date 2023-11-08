using UnityEngine;

public class MoveState : State
{
    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, _movementSpeed * Time.deltaTime);
    }
}