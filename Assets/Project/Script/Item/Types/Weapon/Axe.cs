﻿using UnityEngine;
using System;

public class Axe : Weapon, IEquipableItem, IInstanciableItem
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
        Type = ItemType.Weapon;
        float powerLvl = (float)Rarity;

        SetRandAttributes();

        float baseDamageValue = Mathf.Floor(Mathf.Exp(Level / (6 - powerLvl / 8)) * 15);
        float min = baseDamageValue * (1 - RangeOfGeneration / 100);
        float max = baseDamageValue * (1 + RangeOfGeneration / 100);
        Damage = (int)UnityEngine.Random.Range(min, max);

        Price = (int)(Mathf.Sqrt(Damage) * (10 + powerLvl * 6));
        Weight = 25 + (int)Rarity;

        PrefabPath = "Weapons/Axe";
    }

    public void SetRandName()
    {
        NameObject = NameGenerator.GenerateNewName((int)Rarity, "Axe");
    }

    public void SetRandDescription()
    {
        throw new NotImplementedException();
    }
}
