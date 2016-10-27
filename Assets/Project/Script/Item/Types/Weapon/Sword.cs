﻿using UnityEngine;
using System;

public class Sword : Weapon, IEquipableItem, IInstanciableItem
{
    public void Equip()
    {
        Player player = LevelManager.Instance.Player;
        player.RightHand = this;
        player.CharacterStats.SetCharacteristics(player);
        Equipped = player;
    }

    public void Instantiate()
    {
        Type = item_type.weapon;
        WeaponType = weapon_type.Sword;
        float power_lvl = (float)Rarity;

        SetRandAttributes();

        float base_damage_value = Mathf.Floor(Mathf.Exp(Level / (6 - power_lvl / 8)) * 10);
        float min = base_damage_value * (1 - (RangeOfGeneration / 100));
        float max = base_damage_value * (1 + (RangeOfGeneration / 100));
        Damage = (int)UnityEngine.Random.Range(min, max);

        Price = (int)(Mathf.Sqrt(Damage) * (10 + (power_lvl * 6)));
        Weight = 15 + (int)Rarity;

        PrefabPath = "Weapons/Sword";
    }

    public void SetRandName()
    {
        NameObject = NameGenerator.GenerateNewName((int)Rarity, "Sword");
    }

    public void SetRandDescription()
    {
        throw new NotImplementedException();
    }
}
