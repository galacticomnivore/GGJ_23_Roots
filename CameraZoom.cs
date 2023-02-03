using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraZoom : MonoBehaviour
{

    [SerializeField]
    private float ScrollSpeed = 10;
    private Camera ZoomCamera;
    public float MaxZoomIn;
    public float MaxZoomOut;

    // Start is called before the first frame update
    void Start()
    {
        ZoomCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (ZoomCamera.orthographic)
        {
            float cameraOrthographicTotal = ZoomCamera.orthographicSize + Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
            
            if (cameraOrthographicTotal > MaxZoomIn)
            {
                ZoomCamera.orthographicSize = cameraOrthographicTotal;
            }

            if (cameraOrthographicTotal > MaxZoomOut)
            {
                ZoomCamera.orthographicSize = MaxZoomOut;
            }

        }
        else
        {

            ZoomCamera.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        }

    }
}
