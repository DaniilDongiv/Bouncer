using UnityEngine;

public class CylinderController : MonoBehaviour
{
    private Color[] _colors = { Color.red, Color.yellow, Color.green };
    private Color _color;
    void Start()
    {
        System.Random random = new System.Random();
        var color = random.Next(0, 3);
        _color = GetComponent<Renderer>().material.color = _colors[color];
    }

    private void OnCollisionEnter(Collision collision)
    {
        var cube = collision.gameObject;
        var color = cube.GetComponent<Renderer>().material.color;
        
        if (_color == color)
        {
            Destroy(gameObject);
        }
    }
}
