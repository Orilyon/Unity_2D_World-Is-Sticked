using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silahcontrol : MonoBehaviour
{   public silah startingGun;
	public Transform WeaponHold;
	silah equippedGun;
	void Start(){
		if (startingGun != null) {
			EquipGun (startingGun);
		}
	
	}
    public void EquipGun(silah gunToEquip) {
        if (equippedGun != null)
        {
            Destroy(equippedGun.gameObject);
        }
		equippedGun = Instantiate(gunToEquip, WeaponHold.position,WeaponHold.rotation)as silah;
		equippedGun.transform.parent = WeaponHold;
    }

}