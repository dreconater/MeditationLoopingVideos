using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotationController : MonoBehaviour
{
    [SerializeField] private float damp;

    Quaternion rotation;
    [SerializeField] private bool forceSet = false;
    [SerializeField] private float deltaAngle = 30.0f;

    private Transform cameraTransform;
    private Camera myCam;

    private float x;
    private float y;

    public Transform RotatingObject;

    void Start()
    {
        myCam = GameObject.Find("CenterEyeAnchor").GetComponent<Camera>();
    }

    private void Awake()
    {
        //cameraTransform = myCam.transform;
    }

    public void CamPos(float CamX, float CamY)
    {
        x = CamX;
        y = CamY;
    }

    void Update()
    {

        if (!forceSet)
        {
            if (Mathf.Abs(myCam.transform.rotation.eulerAngles.y - rotation.eulerAngles.y) > deltaAngle)
            {
                RotatingObject.rotation = Quaternion.Lerp(RotatingObject.rotation, myCam.transform.rotation, damp * Time.deltaTime);
            }
        }
        else
        {
            RotatingObject.rotation = myCam.transform.rotation;
        }

        float rotationY = RotatingObject.rotation.eulerAngles.y;
        RotatingObject.rotation = Quaternion.Euler(RotatingObject.rotation.x, rotationY, 0.0f);
    }
}
