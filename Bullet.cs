using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 40;

    public GameObject hitEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy !=null)
        {
            enemy.TakeDamage(damage);
        }
        GameObject hitEffectClone = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(hitEffectClone, 0.3f);
        Destroy(gameObject);
        
    }
    
}
