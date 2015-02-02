using UnityEngine;
using System.Collections;

public class CloudeFacking : MonoBehaviour
{
    public float windSpeedX;
    public float windSpeedZ;
    public float lightCookieSize; // make it equal to the light's Cookie Size parameter in the inspector

    private Vector3 initialPosition;
	Transform myTransform;

    void Start()
    {
        initialPosition = transform.position;
		myTransform = transform;
    }

    void Update()
    {
        if (Mathf.Abs(myTransform.position.x) >= Mathf.Abs(initialPosition.x) + lightCookieSize)
        {
            Vector3 pos = myTransform.position;
            pos.x = initialPosition.x;
            myTransform.position = pos;
        }
        else
        {
            myTransform.Translate(Time.deltaTime * windSpeedX, 0, 0, Space.World);
        }


        if (Mathf.Abs(myTransform.position.z) >= Mathf.Abs(initialPosition.z) + lightCookieSize)
        {
            Vector3 pos = myTransform.position;
            pos.z = initialPosition.z;
            myTransform.position = pos;
        }
        else
        {
            myTransform.Translate(0, 0, Time.deltaTime * windSpeedZ, Space.World);
        }
    }

}