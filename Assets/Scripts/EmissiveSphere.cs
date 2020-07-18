using UnityEngine;
using System.Collections.Generic;
using Unity.Mathematics;

public class EmissiveSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var c_r = UnityEngine.Random.Range(0.0f, 1.0f);
        var c_g = UnityEngine.Random.Range(0.0f, 1.0f);
        var c_b = UnityEngine.Random.Range(0.0f, 1.0f);
        var col = (Color)((Vector4)(new float4(c_r, c_g, c_b, 1)));
        var _intensity = 75000.0f;

        this.GetComponentInChildren<Renderer>().material.SetColor("_EmissiveColor", col * _intensity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
