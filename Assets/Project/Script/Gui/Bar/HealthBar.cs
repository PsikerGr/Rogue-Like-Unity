﻿using UnityEngine;
using UnityEngine.UI;

public class HealthBar : Bar {

    void Update ()
    {
        Characteristics player_stats = player.CharacterStats.UnitCharacteristics;
        float life_ratio = (float)player_stats.Health / (float)player_stats.MaxHealth;

        if (player_stats.Health >= 0)
        {
            bar.localScale = new Vector3(life_ratio, bar.localScale.y, bar.localScale.z);
            point.text = player_stats.Health.ToString();
        }
   }
}