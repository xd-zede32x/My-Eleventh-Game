using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private Sprite _weaponIcon;
    [SerializeField] private string _namesOfWeapons;
    [SerializeField] private int _priceOfWeapons;
    [SerializeField] private bool _purchased = false;

    [SerializeField] protected Bullet Bullet;

    public string Label => _namesOfWeapons;
    public int Price => _priceOfWeapons;
    public Sprite Icon => _weaponIcon;
    public bool Purchased => _purchased;

    public abstract void Shooting(Transform shootPoint);
    
    public void Buy()
    {
        _purchased = true;
    }
}