using UnityEngine;

public class VectorAddition : MonoBehaviour
{
    void Start()
    {
        Vector3 vector1 = new Vector3(2, 1, 0);
        Vector3 vector2 = new Vector3(1, 2, 1);

        Vector3 result = vector1 + vector2;

        CreateCube(vector1, Color.red);
        CreateCube(vector2, Color.blue);
        CreateCube(result, Color.green);
    }

    void CreateCube(Vector3 position, Color color)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = position;

        Renderer cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.color = color;
    }
}