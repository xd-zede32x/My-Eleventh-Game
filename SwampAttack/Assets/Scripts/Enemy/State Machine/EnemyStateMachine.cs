using UnityEngine;

[RequireComponent(typeof(Enemy))]

public class EnemyStateMachine : MonoBehaviour
{
    [SerializeField] private State _firstState;

    private Player _target;
    private State _currenState;

    public State Current => _currenState;

    private void Start()
    {
        _target = GetComponent<Enemy>().Target;
        Reset(_firstState);
    }

    private void Update()
    {
        if (_currenState == null)
            return;
        
        var nextState = _currenState.GetNextState();

        if (nextState != null)
            Transit(nextState);
    }

    private void Reset(State startState)
    {
        _currenState = startState;

        if (_currenState != null)
            _currenState.Enter(_target);
    }

    private void Transit(State nextState)
    {
        if (_currenState != null)
            _currenState.Exit();

        _currenState = nextState;

        if (_currenState != null)
            _currenState.Enter(_target);
    }
} 