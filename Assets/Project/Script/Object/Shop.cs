﻿using UnityEngine;

public class Shop : MonoBehaviour, IUsableObject
{
    private InventoryPanelGui invPanelGui;
    private Inventory inv = new Inventory();

    private void Awake()
    {
        invPanelGui = InventoryPanelGui.Instance;
        if (!invPanelGui)
            Debug.LogError("Can't find InventoryGui on Shop.Awake()");


    }

    private void Start()
    { 
        inv.List = ItemManager.Instance.GenerateInventory(ItemManager.FlagsGeneration.AllType, 10);
        inv.List.Add(ItemManager.Instance.CreateObject<LifePotion>());
        inv.List.Add(ItemManager.Instance.CreateObject<PortalPotion>());
    }

    public void OnUse(ACharacter _character)
    {
        invPanelGui.Inventory = inv;
        invPanelGui.currentGuiAction = InventoryPanelGui.InventoryGuiType.VendorInventory;

        GameManager.Instance.ChangeGameStateTo(GameManager.GameState.Pause);
        invPanelGui.Show = true;
    }
}
