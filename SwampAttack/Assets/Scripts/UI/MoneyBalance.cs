using UnityEngine;
using UnityEngine.UI;

public class MoneyBalance : MonoBehaviour
{
    [SerializeField] private Text _money;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _money.text = _player.Money.ToString() + "$";
        _player.MoneyChanged += OnMoneyChanged;

    }

    private void OnDisable()
    {
        _player.MoneyChanged -= OnMoneyChanged;
    }

    private void OnMoneyChanged(int money)
    {
        _money.text = money.ToString();
    }
}