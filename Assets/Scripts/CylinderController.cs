using UnityEngine;

public class CylinderController : MonoBehaviour
{
    [SerializeField]
    private NumberOfObjects _numberOfObjects;
    
    private Color[] _colors = { Color.red, Color.yellow, Color.green };
    private Color _color;
    void Start()
    {
        System.Random random = new System.Random();
        var color = random.Next(0, 3);
        _color = GetComponent<Renderer>().material.color = _colors[color];
        if (_color == _colors[0])
        {
            _numberOfObjects.Red++;
        }
        if (_color == _colors[1])
        {
            _numberOfObjects.Yellow++;
        }
        if (_color == _colors[2])
        {
            _numberOfObjects.Green++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var cube = collision.gameObject;
        var color = cube.GetComponent<Renderer>().material.color;
        
        if (_color == color)
        {
            if (color == _colors[0])
            {
                _numberOfObjects.Red--;
            }
            if (color == _colors[1])
            {
                _numberOfObjects.Yellow--;
            }
            if (color == _colors[2])
            {
                _numberOfObjects.Green--;
            }
            Destroy(gameObject);
        }
    }
}
