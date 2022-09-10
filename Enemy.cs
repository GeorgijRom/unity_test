using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class Enemy : MonoBehaviour
{
    private float timeBtwAttack;
    public float startBtwAttack;
    private Animator anim;
    public int health = 100;
    public GameObject deathEffect;
    public GameObject hitEffect;
    public GameObject playerHitEffect;
    public int damage = 20;
    public int enemyDamage = 1;
    private PlayerController player;
    private ScoreManager sm;
    private void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        sm = GameObject.Find("ScoreManager").GetComponentInChildren<ScoreManager>();
    }
    public void TakeDamage(int damage)
    {

        health -= damage;
        if(health<=0)
        {
            Die();
            CameraShaker.Instance.ShakeOnce(2f, 3f, 1f, 1f);

        }
        else
        {
            Vector3 pos = transform.position;
            pos.z = 0;
            GameObject hitEffectClone = Instantiate(hitEffect, pos, Quaternion.identity);
            Destroy(hitEffectClone, 0.5f);

        }
    }

    void Die()
    {
        sm.kill();
        Vector3 pos =transform.position;
        pos.z = -1;
        GameObject deathEffectClone = Instantiate(deathEffect, pos, Quaternion.identity);
        Destroy(deathEffectClone, 0.5f);
        Destroy(gameObject);

    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(timeBtwAttack<=0)
            {
                anim.SetTrigger("IsAttack");
              
            }
            else
            {
                timeBtwAttack -= Time.deltaTime;
                anim.ResetTrigger("IsAttack");
            }
        }
    }
    public void OnEnemyAttack()
    {
        Vector3 pos = player.transform.position;
        pos.z = 1;
        GameObject playerHitEffectClone = Instantiate(playerHitEffect, pos, Quaternion.identity);
        Destroy(playerHitEffectClone, 0.5f);
        player.health -= enemyDamage;
        timeBtwAttack = startBtwAttack;
    }
}
