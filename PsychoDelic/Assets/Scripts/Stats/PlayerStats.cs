using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    // Start is called before the first frame update
    void Start()
    {
        WeaponManager.instance.onEquipmentChanged += OnEquipmentChanged;
    }

    void OnEquipmentChanged(Weapons newItem, Weapons oldItem)
    {
        if (newItem != null)
        {
            damage.AddModifier(newItem.damageModifier);
            fireRate.AddModifier(newItem.fireModifier);
        }

        if (oldItem != null)
        {
            damage.RemoveModifier(oldItem.damageModifier);
            fireRate.RemoveModifier(oldItem.fireModifier);
        }

    }
}
