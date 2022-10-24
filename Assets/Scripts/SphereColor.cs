using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColor : MonoBehaviour
{
    [SerializeField]
    private GameObject _sphere;
    
    private Color[] _colors = { Color.red, Color.yellow, Color.green };
    
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = _sphere.GetComponent<Renderer>().material.color;
        System.Random random = new System.Random();
        var valueX = random.Next(-4, 4);
        var valueZ = random.Next(-4, 4);
        var objectCylinder = Instantiate(_sphere);
        Destroy(_sphere.gameObject);
        objectCylinder.transform.position = new Vector3(valueX, 0.7f, valueZ);
        var color = random.Next(0, 3);
        _sphere.GetComponent<Renderer>().material.color = _colors[color];
    }
}
