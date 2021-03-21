using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TestForceMode : MonoBehaviour
{
    public enum Mode
    {
        Acceleration,
        Force,
        Impulse,
        VelocityChange
    }

    [SerializeField] private Mode mode;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (mode)
            {
                case Mode.Acceleration:
                    _rigidbody.AddForce(Vector3.up * 300f, ForceMode.Acceleration);
                    break;  
                    
                case Mode.Force:
                    _rigidbody.AddForce(Vector3.up * 300f, ForceMode.Force);
                    break;    
                    
                case Mode.Impulse:
                    _rigidbody.AddForce(Vector3.up * 300f, ForceMode.Impulse);
                    break;  
                    
                case Mode.VelocityChange:
                    _rigidbody.AddForce(Vector3.up * 300f * .02f, ForceMode.VelocityChange);
                    break;
            }
        }
    }
}
