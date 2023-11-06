using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOrbitSimple : MonoBehaviour
{
    public Transform target;
    public float distance = 100.0f;
    public float distanceStep = 5.0f;
    public float xSpeed = 10.0f;


    public bool rotateOnlyWhenRightMouseButtonPressed = true;

    float x = 0.0f;
    float y = 0.0f;

    void LateUpdate()
    {
        if (rotateOnlyWhenRightMouseButtonPressed && !Input.GetMouseButton(1))
            return;
        if (target)
        {
            x += Input.GetAxis("Mouse X") * xSpeed * distance * 0.02f;
            Quaternion rotation = Quaternion.Euler(y, x, 0);

            distance = distance - Input.GetAxis("Mouse ScrollWheel") * distanceStep;
            Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
            Vector3 position = rotation * negDistance + target.position;

            transform.rotation = rotation;
            transform.position = position;
        }
    }
}
