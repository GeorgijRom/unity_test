using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject shootSound;
    public Transform bulletPoint;
    public GameObject bullet;
    public float bulletForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {

        Vector3 bulletPos = bulletPoint.position;
        bulletPos.z = -1;
        GameObject bulletClone =  Instantiate(bullet, bulletPos, bulletPoint.rotation);
        bulletPos.z = 2;
        GameObject soundClone = Instantiate(shootSound, bulletPos, Quaternion.identity);
        Rigidbody2D rb = bulletClone.GetComponent<Rigidbody2D>();
        rb.AddForce(bulletPoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bulletClone, 3f);
        Destroy(soundClone, 1f);
    }
}
