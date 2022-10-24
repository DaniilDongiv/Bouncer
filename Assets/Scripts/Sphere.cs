using System;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField]
    private GameObject _sphere;
    
    private Color[] _colors = { Color.red, Color.yellow, Color.green };

    void Start()
    {
        System.Random random = new System.Random();
        var valueX = random.Next(-4, 4);
        var valueZ = random.Next(-4, 4);
        var objectSphere = Instantiate(_sphere);
        objectSphere.transform.position = new Vector3(valueX, 0.7f, valueZ);
        var color = random.Next(0, 3);
        objectSphere.GetComponent<Renderer>().material.color = _colors[color];
    }

    
}
