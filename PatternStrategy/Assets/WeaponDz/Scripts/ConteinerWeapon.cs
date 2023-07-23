using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class ConteinerWeapon : MonoBehaviour
{
    [SerializeField] private List<Weapon> weapons;
    [SerializeField] private int activeWeapon;

    [SerializeField] private bool _isMousePressed;


    /* [SerializeField] private int activeWeapon;*/
    void Start()
    {
        ChangeWeapon(activeWeapon);
       
        
    }
    private void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        MousePresing();
        SwapWeapon();
        UseWeapon();
    }
    void MousePresing()
    {
        if (Input.GetMouseButtonDown(0)) _isMousePressed=true;
        if(Input.GetMouseButtonUp(0)) _isMousePressed =false;

    }
    void UseWeapon() => weapons[activeWeapon].Shoting(ref _isMousePressed);
   
    
    void SwapWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            activeWeapon = 0;
            ChangeWeapon(activeWeapon); 
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            activeWeapon = 1;
            ChangeWeapon(activeWeapon);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            activeWeapon = 2;
            ChangeWeapon(activeWeapon);
        }
        
    }


    void ChangeWeapon(int choose)
    {
        for(int i = 0; i < weapons.Count; i++)
            weapons[i].gameObject.SetActive( i== choose);
    }

}
