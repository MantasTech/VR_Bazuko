using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float minRGB = 0f;
    private float maxRGB = 1f;



    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Rotate(70.0f * Time.deltaTime, 0.0f, 0.2f);
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        Material material = Renderer.material;

       
        //Generates a new colour
        material.color = new Color(Random.Range(minRGB, maxRGB), Random.Range(minRGB, maxRGB), Random.Range(minRGB, maxRGB), 1f);
    }
}
