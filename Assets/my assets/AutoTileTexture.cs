using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class AutoTileTexture : MonoBehaviour
{
    public float tileMultiplier = 1f;

    void Start()
    {
        var rend = GetComponent<Renderer>();
        Vector3 size = GetComponent<MeshFilter>().sharedMesh.bounds.size;

        rend.material.mainTextureScale = new Vector2(
            size.x * tileMultiplier,
            size.z * tileMultiplier
        );
    }
}