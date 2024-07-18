using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    public int coins;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
    public void CollectCoins()
    {
        coins++;
        print("Coins: "+ coins);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Health:" + health);
    }
}
