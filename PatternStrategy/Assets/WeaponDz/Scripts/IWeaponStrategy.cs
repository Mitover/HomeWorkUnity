using UnityEngine;

public interface IWeaponStrategy
{
    /*float LastShootTime { get;  }*/
    float BulletPerMinute { get;  }
    int CountCreatBullet { get; }
    bool  CanShoot(float time, ref bool isPressMouse);

}
