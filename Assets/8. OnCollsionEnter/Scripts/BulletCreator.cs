using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float BulletVelocity;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(this.bullet, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletVelocity;
        }
    }
}
