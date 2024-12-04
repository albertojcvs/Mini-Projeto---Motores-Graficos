using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovimentacaoSeta : MonoBehaviour
{
    public float maxSpeed = 10f;
    public float acceleration = 5f;
    public float deceleration = 2f;
    public float rotationSpeed = 100f;

    private float currentSpeed = 0f;

    public TextMeshProUGUI textoVelocidade;
    private float forwardWay = 0f;

    
    public Camera camera;

    void Start()
    {
    }

    void Update()
    {
        
        float moveForward = Input.GetKey(KeyCode.UpArrow) ? 1f : (Input.GetKey(KeyCode.DownArrow) ? -1f : 0f);
        float moveRight = Input.GetKey(KeyCode.RightArrow) ? 1f : (Input.GetKey(KeyCode.LeftArrow) ? -1f : 0f);

        
        if (moveForward != 0f)
        {
            forwardWay = moveForward;
            currentSpeed += acceleration * Time.deltaTime;
            currentSpeed = Mathf.Clamp(currentSpeed, -maxSpeed, maxSpeed);
        }
        else
        {
            currentSpeed -= deceleration * Time.deltaTime;
            currentSpeed = Mathf.Clamp(currentSpeed, 0f, maxSpeed);
        }

        
        transform.Translate(Vector3.forward * currentSpeed * forwardWay * Time.deltaTime);
        transform.Translate(Vector3.right * moveRight * maxSpeed * Time.deltaTime);

        
        textoVelocidade.text = "Speed: " + currentSpeed.ToString("F2");

        
        RotateShip(moveRight);
    }

    void RotateShip(float moveRight)
    {
        if (moveRight != 0f)
        {
            float rotation = moveRight * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * rotation);
        }
    }
}
