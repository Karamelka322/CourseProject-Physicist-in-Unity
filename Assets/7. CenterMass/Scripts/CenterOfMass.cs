using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    [SerializeField] private Transform centerOfMass;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = Vector3.Scale(centerOfMass.localPosition, transform.localScale);
    }

    private void Update()
    {
        _rigidbody.WakeUp();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(GetComponent<Rigidbody>().worldCenterOfMass, 0.2f);
    }
}
