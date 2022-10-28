using UnityEngine;

public class Cylinder : MonoBehaviour
{
    [SerializeField]
    private GameObject _cylinder;
    [SerializeField]
    private NumberOfObjects _numberOfObjects;
    
    void Start()
    {
        System.Random randomPlayer = new System.Random();
        var valueXPleyer = randomPlayer.Next(-4, 4);
        var valueZPleyer = randomPlayer.Next(-4, 4);
        _cylinder.transform.position = new Vector3(valueXPleyer, 0.7f, valueZPleyer);
        
        for (int i = 0; i < 5; i++)
        {
            System.Random random = new System.Random();
            var valueX = random.Next(-4, 4);
            var valueZ = random.Next(-4, 4);
            var objectCylinder = Instantiate(_cylinder);
            objectCylinder.transform.position = new Vector3(valueX, 0.7f, valueZ);
        }
        
    }
}
