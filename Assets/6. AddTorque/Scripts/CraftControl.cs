using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CraftControl : MonoBehaviour
{
    public float Speed = 5f;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * Speed;
        float forwardForce = Input.GetAxis("Vertical") * Speed;

        _rigidbody.AddRelativeForce(sideForce, 0f, forwardForce);
        _rigidbody.AddRelativeTorque(0f, sideForce * .2f, 0f);
    }
}
