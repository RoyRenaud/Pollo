using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour
{
    private float camX;
    private float camY;
    private Vector3 rotateValue;

    private void Update()
    {

        var y = Input.GetAxis("Mouse Y");
        rotateValue = new Vector3(0, y * -1, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;
    }

}