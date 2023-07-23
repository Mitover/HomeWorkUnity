using UnityEngine;

public class AutoShootStrategy : IWeaponStrategy
{


    [SerializeField] private float _lastShootTime;
    [SerializeField] private float _bulletPerMinute;
    [SerializeField] private int _countCreate;

    public AutoShootStrategy(float bulletPerMinute )
    {
        _bulletPerMinute = bulletPerMinute;
        _countCreate = 1;
    }

    public float BulletPerMinute => _bulletPerMinute;
    public int CountCreatBullet => _countCreate;

    public bool CanShoot(float time, ref bool isPressMouse)
    {
        if ((time - _lastShootTime > 60.0f / _bulletPerMinute) && isPressMouse)
        {
            Debug.Log($"{time - _lastShootTime} - {60.0f / _bulletPerMinute}");
            /* Instantiate(_bullet, spawnBullet.position, Quaternion.identity).GetComponent<Rigidbody>().AddForce(spawnBullet.forward * forceBullet, ForceMode.Impulse); */
            _lastShootTime = time;
            return true;
        }
        return false;
    }

 


}
