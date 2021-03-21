using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public float Distanse;
    public LayerMask Mask;


    private void Update()
    {
        Ray ray = new Ray(transform.position, -Vector3.up);
        Debug.DrawRay(ray.origin, ray.direction * Distanse, Color.yellow);

        if(Physics.Raycast(ray, Distanse, Mask))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
