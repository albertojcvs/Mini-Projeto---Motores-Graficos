using UnityEngine;

public class rotacao : MonoBehaviour
{
    public Vector3 rotationAxis = new Vector3(0, 1, 0);
    public float rotationSpeed = 10f;


    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
