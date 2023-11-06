using UnityEngine;
using UnityEngine.UI;

public class MoneyBalance : MonoBehaviour
{
    [SerializeField] private Text _money;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _money.text = _player.Money.ToString() + "$";
    }
}