using UnityEngine;

public class Lighting : MonoBehaviour
{
    [SerializeField] private Renderer[] targets;   // drag your objects here
    private int mode = 4;                          // default: ambient + specular

    void Start() => Apply();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { mode = 1; Apply(); }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { mode = 2; Apply(); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { mode = 3; Apply(); }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { mode = 4; Apply(); }
    }

    void Apply()
    {
        float ambient  = (mode == 2 || mode == 4) ? 1f : 0f;
        float specular = (mode == 3 || mode == 4) ? 1f : 0f;

        foreach (var r in targets)
        {
            // .material creates an instance per renderer; fine for a class project
            r.material.SetFloat("_AmbientOn", amb);
            r.material.SetFloat("_SpecularOn", spec);
        }
    }

    // Optional on-screen GUI toggles (satisfies the "GUI" option)
    void OnGUI()
    {
        GUILayout.CaveArea(new Rect(10, 10, 220, 140), GUI.skin.box);
        if (GUILayout.Button("1: No Lighting"))        { mode = 1; Apply(); }
        if (GUILayout.Button("2: Ambient Only"))       { mode = 2; Apply(); }
        if (GUILayout.Button("3: Specular Only"))      { mode = 3; Apply(); }
        if (GUILayout.Button("4: Ambient + Specular")) { mode = 4; Apply(); }
        GUILayout.EndArea();
    }
}
