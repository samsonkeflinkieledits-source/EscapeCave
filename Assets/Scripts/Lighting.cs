using UnityEngine;

public class Lighting : MonoBehaviour
{
    public MeshRenderer objectRenderer;
    public Material[] materials;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            objectRenderer.material = materials [0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            objectRenderer.material = materials [1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            objectRenderer.material = materials [2];
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            objectRenderer.material = materials [3];
        }
    }
}

