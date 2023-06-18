using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Profiling;
using Unity.Jobs;
using Unity.Collections;
using Unity.Burst;
using TMPro;
using Rewired;
using System.Threading;
using System.Threading.Tasks;

[BurstCompile]
public class AudioVisualizer : MonoBehaviour
{

    public Matrix4x4 matrix;

    public float intensity = 1f;
    public float scale = 1f;
    public int resolution = 128;
    public float radius = 1f;

    public AudioSource audioSource;
    public float[] spectrumData;
    public Mesh mesh;
    public Vector3[] vertices;
    public int[] triangles;

    public bool isMeshAudio = false;

    public Material targetMesh;

    void Start()
    {

        targetMesh = new Material(Shader.Find("PSXEffects/PS1Screen"));

        audioSource = GetComponent<AudioSource>();

        // Crear malla
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        // Calcular número de vértices y triángulos
        int numVertices = resolution + 1;
        int numTriangles = resolution * 3;

        // Inicializar arreglos
        vertices = new Vector3[numVertices];
        triangles = new int[numTriangles];

        // Calcular ángulo entre cada vértice
        float angleIncrement = 360f / resolution;

        // Crear vértices
        for (int i = 0; i < numVertices; i++)
        {
            float angle = i * angleIncrement;
            float x = Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
            float y = 0f;
            float z = Mathf.Sin(angle * Mathf.Deg2Rad) * radius;
            vertices[i] = new Vector3(x, y, z);
        }

        // Crear triángulos
        for (int i = 0; i < resolution; i++)
        {
            int triangleIndex = i * 3;
            triangles[triangleIndex] = 0;
            triangles[triangleIndex + 1] = i + 1;
            triangles[triangleIndex + 2] = i + 2;
        }
        triangles[numTriangles - 1] = 1;

        // Asignar vértices y triángulos a la malla
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }

    void Update()
    {
        // Obtener los datos del espectro del audio
        spectrumData = new float[resolution];
        audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.BlackmanHarris);

        // Actualizar la posición de los vértices según los datos del espectro
        for (int i = 0; i < resolution; i++)
        {
            Vector3 vertex = vertices[i + 1];
            vertex.y = spectrumData[i] * intensity * scale;
            vertices[i + 1] = vertex;
        }

        // Asignar los vértices actualizados a la malla
        mesh.vertices = vertices;
        Graphics.DrawMesh(mesh, matrix, targetMesh, 8);
    }

    public Mesh updateMesh()
    {
        return mesh;
    }
}