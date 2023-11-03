using UnityEngine;

public class Pistol : Weapon
{
    public override void Shooting(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.identity);
    }
}