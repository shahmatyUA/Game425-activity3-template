// ISTA 425 / INFO 525 Algorithms for Games
//
// Sample code file
//   Provides samples and starter code for a
//   variety of important 3D vector operations.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMath : MonoBehaviour
{
    // An array of 6 designer-specified 3D vectors

    [Tooltip("Array of six 3D vector elements")]
    public Vector3[] vectorSet = new Vector3[] {new Vector3( 1.0f, 8.0f, 5.0f),   // element 0
                                                new Vector3( 4.0f,-2.0f, 4.0f),   // element 1
                                                new Vector3( 2.0f, 1.0f,-3.0f),   // element 2
                                                new Vector3( 1.0f, 2.0f, 3.0f),   // element 3
                                                new Vector3(-2.0f, 1.0f,-2.0f),   // element 4
                                                new Vector3( 1.0f,-1.0f, 0.0f)};  // element 5

    // An array of 2 designer-specified 4x4 matrices

    [Tooltip("Array of two 4x4 matrix elements")]   // element 0
    public Matrix4x4[] matrixSet = new Matrix4x4[] {new Matrix4x4(new Vector4( 0.298129f, 0.814423f, 0.497814f, 0.0f),
                                                                  new Vector4( 0.913971f,-0.093164f,-0.394939f, 0.0f),
                                                                  new Vector4(-0.275273f, 0.572731f,-0.772143f, 0.0f),
                                                                  new Vector4( 0.0f,      0.0f,      0.0f,      1.0f)),
                                                    // element 1
                                                    new Matrix4x4(new Vector4( 0.5f, 0.0f, 0.0f, 0.0f),
                                                                  new Vector4( 0.0f,-0.8f, 0.0f, 0.0f),
                                                                  new Vector4(-0.2f, 0.0f, 0.0f, 0.0f),
                                                                  new Vector4( 0.0f, 0.0f, 0.0f, 1.0f)) };
    // A designer-specified surface normal

    [Tooltip("Normal of reflection surface")]
    public Vector3 surfNormal = new Vector3(0.5f, 0.3f, 0.8f);

    // A sample private method visible only within this class;
    // Useful in OOP to contain frequently used operations.
    private void helloWorldHelper()
    {
        Debug.Log("Hello World, from helper method!", this);
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 normVecUnity;
        Vector3 refVecUnity;
        Vector3 crossProdUnity;
        float dotProdUnity;
        float angleUnity;

        Vector3 normVecComp;
        Vector3 refVecComp;
        Vector3 crossProdComp;
        float dotProdComp;
        float angleComp;

        Matrix4x4 M;

        // a sample call to our helper method
        helloWorldHelper();

        //  a loop through the array of vectors for Question 1
        for (int i = 0; i < vectorSet.Length; i++)
        {
            Debug.Log("------ Q1: Loop for i =" + i + " ------");
            Debug.Log("Vector[" + i + "] = " + vectorSet[i]);

            // TODO: 1(a), Compute normVecComp
            normVecComp = new Vector3(0.0f, 0.0f, 0.0f);
            normVecUnity = vectorSet[i].normalized;
            Debug.Log("Computed Normal: " + normVecComp + ", Unity Normal: " + normVecUnity);

            // TODO: 1(b) Compute refVecComp
            refVecComp = new Vector3(0.0f, 0.0f, 0.0f);
            refVecUnity = Vector3.Reflect(vectorSet[i], surfNormal);
            Debug.Log("Computed Reflection: " + refVecComp + ", Unity Reflection: " + refVecUnity);
        }

        //  a loop creating all pairwise combinations for Question 2
        for (int i = 0; i < vectorSet.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Debug.Log("------ Q2: Loop for i = " + i + ", j = " + j + " ------");
                Debug.Log("Vector[" + i + "] = " + vectorSet[i] + ", Vector[" + j + "] = " + vectorSet[j]);

                // TODO: 2(a) Compute angleComp
                angleComp = 0.0f;
                angleUnity = Vector3.Angle(vectorSet[i], vectorSet[j]);
                Debug.Log("Computed Angle: " + angleComp + ", Unity Angle: " + angleUnity);

                // TODO: 2(b) Compute dotProdComp
                dotProdComp = 0.0f;
                dotProdUnity = Vector3.Dot(vectorSet[i], vectorSet[j]);
                Debug.Log("Computed Dot Product: " + dotProdComp + ", Unity Dot Product: " + dotProdUnity);

                // TODO: 2(c) Compute crossProdComp
                crossProdComp = new Vector3(0.0f, 0.0f, 0.0f);
                crossProdUnity = Vector3.Cross(vectorSet[i], vectorSet[j]);
                Debug.Log("Computed Cross Product: " + crossProdComp + ", Unity Cross Product: " + crossProdUnity);
            }
        }

        // TODO: 3. Are any combinations of vectors in Q1 or Q2 giving
        //          strange or nonsensical results? Why so or why not?

        //  a loop through the array of matrices for Question 4
        for (int k = 0; k < matrixSet.Length; k++)
        {
            Debug.Log("------ Loop for Matrix " + k + " ------");
            Debug.Log("Matrix[" + k + "] = " + matrixSet[k]);

            // TODO: 4(a) Compute transpose
            M = matrixSet[k];
            Debug.Log("Transpose = " + M);

            // TODO: 4(b) Compute inverse
            M = matrixSet[k];
            Debug.Log("Inverse = " + M);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // NULL
    }
}
