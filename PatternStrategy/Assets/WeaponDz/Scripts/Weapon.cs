using UnityEngine;

public class Weapon : MonoBehaviour 
{

    [SerializeField] IWeaponStrategy _weapon;
   

    [SerializeField] Bullet _bullet;
    [SerializeField] private Transform _bulletSpawn;
    /*[SerializeField] private Transform posWeapon;*/
    [SerializeField] private float _forceBullet;
    [SerializeField] private float _bulletPerMinute;
    [SerializeField] private int _countCreateBullet;


    private void Awake()
    {
        _weapon = new SingleShootingStrategy(_bulletPerMinute);
    }
    private void Update()
    {
        ChangeStrategyWeapon();
    }
    public void ChangeStrategyWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _weapon = new SingleShootingStrategy(_bulletPerMinute);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _weapon = new ThreeShootingStrategy(_bulletPerMinute);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _weapon = new AutoShootStrategy(_bulletPerMinute);
        }

    }
    public void Shoting(ref bool _mouse) 
    {

        if (_weapon.CanShoot(Time.time, ref _mouse))
          for (int i = 0; i < _weapon.CountCreatBullet; i++)
              Instantiate(_bullet, _bulletSpawn.position, Quaternion.identity).GetComponent<Rigidbody>().AddForce(_forceBullet * _bulletSpawn.forward, ForceMode.Impulse);

    }



   
}
