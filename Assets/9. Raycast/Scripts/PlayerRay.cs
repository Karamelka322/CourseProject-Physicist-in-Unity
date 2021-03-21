using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    public Transform pointer;

    private Ray ray;
    private RaycastHit raycastHit;

    private void LateUpdate()
    {
        ray = new Ray(transform.position, transform.forward);

        Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);

        if (Physics.Raycast(ray, out raycastHit))
        {
            pointer.position = raycastHit.point;
            Debug.Log("Hot");
        }
    }
}
