using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private Sprite _weaponIcon;
    [SerializeField] private string _namesOfWeapons;
    [SerializeField] private int _priceOfWeapons;
    [SerializeField] private bool _purchased = false;
    [SerializeField] protected Bullet Bullet;

    public abstract void Shooting(Transform shootPoint);
}