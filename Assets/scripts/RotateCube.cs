using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public Transform target;
    public Vector3 rotationAxis = Vector3.right;
    public float rotationSpeed = 50f;

    void Update()
    {
        if (target != null)
        {
            transform.RotateAround(target.position, rotationAxis, rotationSpeed * Time.deltaTime);
        }
    }
}
