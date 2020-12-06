﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapphire5Pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameSavingInformation.sapphire5Collected = true;
        }
    }
}