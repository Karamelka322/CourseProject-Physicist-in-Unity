using UnityEngine;

public class Bang : MonoBehaviour
{
    public Rigidbody targetRigidbody;
    public float forceValue = 100f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetRigidbody.AddForceAtPosition(transform.up * forceValue, transform.position);
        }
    }
}
