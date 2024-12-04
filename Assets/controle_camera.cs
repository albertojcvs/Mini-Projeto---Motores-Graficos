using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Camera mainCamera;
    public float defaultFOV = 60f;
    public float zoomedFOV = 30f;
    public float transitionSpeed = 5f;


    public KeyCode defaultViewkey = KeyCode.Alpha1;
    public KeyCode zoomViewkey = KeyCode.Alpha2;

    private float targetFOV;

    void Start()
    {
    
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }

    
        targetFOV = defaultFOV;
        mainCamera.fieldOfView = defaultFOV;
    }

    void Update()
    {
        if (Input.GetKeyDown(defaultViewkey))
        {
            targetFOV = defaultFOV;
        }
        else if (Input.GetKeyDown(zoomViewkey))
        {
            targetFOV = zoomedFOV;
        }

        mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, targetFOV, Time.deltaTime * transitionSpeed);
    }
}