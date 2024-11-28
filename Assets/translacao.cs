using UnityEngine;

public class translacao : MonoBehaviour
{
    public Transform principal;
    public float velocidadeOrbita = 10f; 
    public float radius = 3f;

    private float angle = 0f;


void Start()
{
    float x = principal.position.x + Mathf.Cos(angle) * radius;
    float z = principal.position.z + Mathf.Sin(angle) * radius;
    transform.position = new Vector3(x, transform.position.y, z);
}

void Update()
{
    angle += velocidadeOrbita * Time.deltaTime;

    float x = principal.position.x + Mathf.Cos(angle) * radius;
    float z = principal.position.z + Mathf.Sin(angle) * radius;

    transform.position = new Vector3(x, transform.position.y, z);
}
}
