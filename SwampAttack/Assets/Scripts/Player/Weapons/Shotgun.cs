using UnityEngine;

public class Shotgun : Weapon
{
    public override void Shooting(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.identity);
    }
}