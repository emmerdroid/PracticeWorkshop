using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Enemy : MonoBehaviour
{
    public int damage = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        SCR_Health playerHealth;
        playerHealth = other.GetComponent<SCR_Health>();
        if(playerHealth.gameObject.tag == "Player")
        {
            playerHealth.Damage(damage);
        }
    }
}
