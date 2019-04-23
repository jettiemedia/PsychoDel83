using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Inventory/Weapon")]
public class Weapons : Item
{
    public WeaponSlot weaponSlot;

    public int damageModifier;
    public int fireModifier;

    public override void Use()
    {
        base.Use();
        WeaponManager.instance.Equip(this);
        //RemoveFromInventory();
    }
}

public enum WeaponSlot { Weapon}
