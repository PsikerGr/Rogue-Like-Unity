﻿using System;
using UnityEngine;

public class Boots : Armor, IEquipableItem, IInstanciableItem
{
    public void Equip()
    {
        Player player = LevelManager.Instance.Player;
        player.Boots = this;
        player.CharacterStats.SetCharacteristics(player);
        Equipped = player;
    }

    public void Instantiate()
    {
        Type = item_type.armor;
        ArmorType = armor_type.Boots;
        float power_lvl = (float)Rarity;

        SetRandAttributes();

        float base_armor_value = Mathf.Floor(Mathf.Exp(Level / (6 - power_lvl / 8)) * 2);
        float min = base_armor_value * (1 - (RangeOfGeneration / 100));
        float max = base_armor_value * (1 + (RangeOfGeneration / 100));
        Defense = (int)UnityEngine.Random.Range(min, max);

        Price = (int)(Mathf.Sqrt(Defense) * (10 + (power_lvl * 6)));

        Weight = 5 + (int)Rarity;
    }

    public void SetRandName()
    {
        NameObject = NameGenerator.GenerateNewName((int)Rarity, "Boots");
    }

    public void SetRandDescription()
    {
        throw new NotImplementedException();
    }
}
