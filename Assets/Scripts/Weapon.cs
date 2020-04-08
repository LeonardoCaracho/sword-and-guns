﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject shooter;

    private Transform _firePoint;
    // Start is called before the first frame update

    void Awake(){
        _firePoint = transform.Find("FirePoint");
    }

    void Start()
    {
        // Invoke("Shoot", 1f);
    }

    // Update is called once per frame
    public void Shoot()
    {
        if (bulletPrefab != null && _firePoint != null && shooter != null){
            GameObject myBullet = Instantiate(bulletPrefab, _firePoint.position, Quaternion.identity) as GameObject;

            Bullet bulletComponent = myBullet.GetComponent<Bullet>();

            if (shooter.transform.localScale.x < 0f){
                bulletComponent.direction = Vector2.left;
            } else {
                bulletComponent.direction = Vector2.right;
            }
        }
    }
}
