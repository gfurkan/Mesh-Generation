using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{

    Vector3[] vertices;
    int[] triangles;
    Mesh mesh;

    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        vertices = new Vector3[]
        {
            Vector3.zero,
            Vector3.forward,
            Vector3.right,
            Vector3.forward+Vector3.right
        };
        triangles = new int[]
        {
            0,
            1,
            2,
            1,
            3,
            2
        };
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
