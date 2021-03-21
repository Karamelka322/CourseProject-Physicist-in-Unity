using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private float forceWater;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float divePercent = -transform.localPosition.y + transform.localScale.x * 0.5f;
        divePercent = Mathf.Clamp(divePercent, 0f, 1f);

        _rigidbody.AddForce(Vector3.up * divePercent * forceWater);
        _rigidbody.drag = divePercent * 2f;
        _rigidbody.angularDrag = divePercent;
    }
}
