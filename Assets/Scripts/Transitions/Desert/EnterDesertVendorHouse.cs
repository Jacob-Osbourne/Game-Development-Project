﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDesertVendorHouse : MonoBehaviour
{
    private PlayerChar player;
    [SerializeField] ItemSaveManager itemSaveManager;
    [SerializeField] InventoryManager inventoryManager;

    public void Start()
    {
        if (itemSaveManager == null)
        {
            itemSaveManager = FindObjectOfType<ItemSaveManager>();
        }

        if (inventoryManager == null)
        {
            inventoryManager = FindObjectOfType<InventoryManager>();
        }
        if (player == null)
        {
            player = FindObjectOfType<PlayerChar>();
        }
    }
    private void OnTriggerEnter2D(Collider2D thing)
    {
        if (thing.CompareTag("Player"))
        {
            GameSavingInformation.whereAmI = "Desert Vendor House";
            GameSavingInformation.whereWasI = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("Desert Vendor House");
            GameSavingInformation.playerX = 0f;
            GameSavingInformation.playerY = -1.5f;
            SaveSystem.SavePlayer(player);
            SaveSystem.SaveGameInfo();
            SaveSystem.SaveQuestInfo();
            itemSaveManager.SaveEquipment(inventoryManager);
            itemSaveManager.SaveInventory(inventoryManager);
        }
    }
}
