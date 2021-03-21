using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject MarkPrefab;

    private float time = 2f;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(time > 0)
        {
            _rigidbody.AddForce(transform.forward);
            time -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rigidbody.useGravity = true;

        Enemy scriptEnemy = collision.gameObject.GetComponent<Enemy>();

        if (scriptEnemy)
        {
            scriptEnemy.OnHit();

            Vector3 position = collision.contacts[0].point;
            Quaternion rotation = Quaternion.LookRotation(collision.contacts[0].normal);

            GameObject mark = Instantiate(MarkPrefab, position, rotation);
            mark.transform.parent = collision.transform;

            Destroy(gameObject);
        }
    }
}
