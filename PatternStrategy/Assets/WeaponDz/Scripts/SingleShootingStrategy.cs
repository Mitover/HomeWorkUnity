using UnityEngine;

[System.Serializable]
public class SingleShootingStrategy :  IWeaponStrategy 
{

    [SerializeField] private float _lastShootTime;
    [SerializeField] private float _bulletPerMinute;
    [SerializeField] private int _countCreate;
  

    /*[SerializeField] private Bullet _bullet;*/
/*
    public float LastShootTime => _lastShootTime;*/


    public float BulletPerMinute => _bulletPerMinute;

    public int CountCreatBullet => _countCreate;

    public SingleShootingStrategy(  float bulletPerMinute)
    {
        _lastShootTime = 0;
        _bulletPerMinute = bulletPerMinute;
        _countCreate = 1;
 
       /* _bullet = bullet;*/
    }

    public bool CanShoot( float time, ref bool isPressMouse)
    {
        
        if ( (time - _lastShootTime > 60.0f / _bulletPerMinute ) && isPressMouse )
        {
            Debug.Log($"{time - _lastShootTime } - { 60.0f / _bulletPerMinute}");
            /* Instantiate(_bullet, spawnBullet.position, Quaternion.identity).GetComponent<Rigidbody>().AddForce(spawnBullet.forward * forceBullet, ForceMode.Impulse); */
            isPressMouse = false;
            _lastShootTime =time; 
            return true;
        }
        return false;
        
    }

  
    
}
