using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        float number1 = 3f;
        float number2 = 4f;

        float sum = number1 + number2;

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(0, sum, 0);
        sphere.AddComponent<SphereClickHandler>();
    }
}

public class SphereClickHandler : MonoBehaviour
{
    private Renderer sphereRenderer;

    void Start()
    {
        sphereRenderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        sphereRenderer.material.color = Random.ColorHSV();
    }
}