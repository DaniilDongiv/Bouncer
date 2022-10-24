using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField]
    private Player _player;

    [SerializeField]
    private LayerMask _layer;
    
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hitInfo, 30f,_layer))
        {
            if (Input.GetMouseButtonDown(0))
            {
                var point = hitInfo.point;
                _player.StartMove(point);
            }
        }
    }
}
