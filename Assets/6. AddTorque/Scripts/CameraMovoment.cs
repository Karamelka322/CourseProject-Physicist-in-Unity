using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovoment : MonoBehaviour
{
    [SerializeField] private Transform target;
    [Space]
    [SerializeField] private float speedPosition;
    [SerializeField] private float speedRotation;
    [Space]
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;

    private void FixedUpdate()
    {
        var newPosition = new Vector3(target.localPosition.x + offsetX,
            target.localPosition.y + offsetY, target.localPosition.z);        

        transform.position = Vector3.Lerp(transform.position, newPosition,
            Time.deltaTime * speedPosition);


        var newRotation = Quaternion.LookRotation(target.position - transform.position);

        transform.rotation = Quaternion.Lerp(transform.rotation,
            newRotation, Time.deltaTime * speedRotation);
    }
}
