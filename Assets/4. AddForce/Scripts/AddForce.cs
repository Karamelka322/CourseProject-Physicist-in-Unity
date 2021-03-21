using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AddForce : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(0f, 200f, 0f);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(-15f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(15f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(0f, 0, 15f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(0f, 0f, -15f);
        }
    }
}
