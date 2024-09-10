// ISTA 425 / INFO 525 Algorithms for Games
//
// Sample code file
//   Performs frame-rate indpendent movement

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    // A designer-specified, arbitrary movement rate.
    // Set via Unity IDE in the Translation component
    // of the GameObject to which this script is attached.

    [Tooltip("Frame-rate independent movement")]
    public float MoveRate = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Translation component initialized.", this);
    }

    // Update is called once per frame
    void Update()
    {
        // input from up/down, left/right keys
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, y, 0.0f);
        
        // a framerate independent translation along
        // the vector defined by user directional inputs
        transform.Translate(move.normalized * MoveRate * Time.deltaTime);
    }
}
