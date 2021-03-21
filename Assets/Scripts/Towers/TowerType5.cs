﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// type5: non-bullet explosion tower

public class TowerType5 : Tower
{
    public void Start()
    {
        range = 3.0f;
        fireRate = 2.0f;
        InvokeRepeating("UpdateTarget", 0.0f, 0.5f); // invoke UpdateTarget() every 0.5 seconds starts from 0 second
    }

    protected override void Shoot()
    {
        GameObject bulletInst = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletInst.GetComponent<BulletType3>();

        if (bullet != null)
        {
            bullet.LocateTarget(target);
            // shooting audio
            bullet.GetComponent<AudioSource>().Play();
        }
    }
}


