using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WeaponView : MonoBehaviour
{
    [SerializeField] private Text _labelOfWeapon;
    [SerializeField] private Text _priceOfWeapon;
    [SerializeField] private Image _iconOfWeapon;
    [SerializeField] private Button _sellButton;

    private Weapon _weapon;

    public event UnityAction<Weapon, WeaponView> SellButtonClick;

    private void OnEnable()
    {
        _sellButton.onClick.AddListener(OnButtonClick);
        _sellButton.onClick.AddListener(TryLockItem);
    }

    private void OnDisable()
    {
        _sellButton.onClick.RemoveListener(OnButtonClick);
        _sellButton.onClick.RemoveListener(TryLockItem);
    }

    private void TryLockItem()
    {
        if (_weapon.Purchased)
            _sellButton.interactable = false;
    }

    public void Render(Weapon weapon)
    {
        _weapon = weapon;

        _labelOfWeapon.text = weapon.Label;
        _priceOfWeapon.text = weapon.Price.ToString();
        _iconOfWeapon.sprite = weapon.Icon;
    }

    private void OnButtonClick()
    {
        SellButtonClick?.Invoke(_weapon, this);
    }
}