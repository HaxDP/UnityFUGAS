using UnityEngine;

public class CubeTower : MonoBehaviour
{
    public float cubeSize = 1f;
    public float spacing = 0.1f;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0, i * (cubeSize + spacing), 0);
            cube.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
        }
    }
}
