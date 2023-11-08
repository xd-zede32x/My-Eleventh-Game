using UnityEngine;

public class Uzi : Weapon
{
    public override void Shooting(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.identity);
    }
}