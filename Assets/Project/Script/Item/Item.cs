﻿using UnityEngine;
using System.Collections;

public class Item// : MonoBehaviour
{
    public enum item_type
    {
        undefined,
        weapon,
        armor,
        useable
    }

    public enum item_rarity
    {
        common,
        uncommon,
        rare,
        epic,
        legendary
    }

    protected string name_object = "Unnamed";
    public string NameObject
    {
        get { return name_object; }
        set { name_object = value; }
    }

    protected string description = "Any description";
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    protected float weight = 0;
    public float Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    protected item_type type = item_type.undefined;
    public item_type Type
    {
        get { return type; }
        set { type = value; }
    }

    private item_rarity rarity;
    public item_rarity Rarity
    {
        get { return rarity; }
        set { rarity = value; }
    }

    public string GetItemGeneralInformations()
    {
        return "Name : " + name_object + "\nDescription : " + description + "\nWeight : " + weight + "\nRarity : " + rarity;
    }

}