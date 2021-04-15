﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType3 : Enemy
{
    void Start()
    {
        maxHealth = 200;
        startSpeed = 2.0f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        value = 12;
        attackPoint = 10;
    }
}