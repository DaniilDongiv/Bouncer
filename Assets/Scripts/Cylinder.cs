using UnityEngine;

public class Cylinder : MonoBehaviour
{
    [SerializeField]
    private GameObject _cylinder;
    
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            System.Random random = new System.Random();
            var valueX = random.Next(-4, 4);
            var valueZ = random.Next(-4, 4);
            var objectCylinder = Instantiate(_cylinder);
            objectCylinder.transform.position = new Vector3(valueX, 0.7f, valueZ);
        }
        
    }
}
