using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected int maxHealth;
    protected int currentHealth;
    protected float startSpeed;
    public float speed;
    public int value;
    public int attackPoint;
    public HealthBar healthbar;
    public bool isDead = false;
    public int wayPointIndex = 0;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetCurrentHealth(currentHealth);

        if (currentHealth <= 0 && !isDead)
        {
            Die();
        }
    }

    public void StopMovement()
    {
        speed = 0;
    }

    public void SlowDown(float slowPercent)
    {
        speed = startSpeed * (1f - slowPercent);
    }

    public void WalkBack(bool isBewitched = false)
    {
        if (isBewitched == true)
        {
            wayPointIndex = gameObject.GetComponent<EnemyMovement>().wayPointIndex;
            gameObject.GetComponent<EnemyMovement>().enabled = false;
            gameObject.GetComponent<EnemyMovementBack>().enabled = true;
        }
    }

    public virtual void Die()
    {
        isDead = true;
        StopMovement();
        PlayerStatus.money += value;
        WaveSpawner.aliveEnemyNumber--;
        Destroy(gameObject);

        // death audio
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
    }
}
