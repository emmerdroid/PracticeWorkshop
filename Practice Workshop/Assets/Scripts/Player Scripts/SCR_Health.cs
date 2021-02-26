using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Health : MonoBehaviour
{
    public int health = 5;

    private void Update() 
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage(int minus)
    {
        health -= minus;
    }
}
