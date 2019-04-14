using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    #region Singleton

    public static WeaponManager instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    Weapons[] currentWeapons;

    public delegate void OnEquipmentChanged(Weapons newItem, Weapons oldItem);
    public OnEquipmentChanged onEquipmentChanged;

    Inventory inventory;

    private void Start()
    {
        inventory = Inventory.instance;

        int numSlots = System.Enum.GetNames(typeof(WeaponSlot)).Length;
        currentWeapons = new Weapons[numSlots];
    }

    public void Equip(Weapons newItem)
    {
        int slotIndex = (int)newItem.weaponSlot;

        Weapons oldItem = null;
        
        if (currentWeapons[slotIndex] != null)
        {
            oldItem = currentWeapons[slotIndex];
            inventory.Add(oldItem);
        }

        if (onEquipmentChanged != null)
        {
            onEquipmentChanged.Invoke(newItem, oldItem);
        }

        currentWeapons[slotIndex] = newItem;
    }

}
