using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;

    [SerializeField]
    private NumberOfClicks _numberOfClicks;
    
    private Vector3 _target;
    private float _stoppingDistace = 0.1f;
    private bool _isMoving;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (!_isMoving)
        {
            return;   
        }

        var dinstanceToDestination = Vector3.Distance(_target, transform.position);
        var shouldStop = dinstanceToDestination < _stoppingDistace;
        if (shouldStop)
        {
            _isMoving = false;
            return;
        }
    }

    public void StartMove(Vector3 target)
    {
        _isMoving = true;
        _target = target;
        _rigidbody.AddForce(_target, ForceMode.Impulse);
        _numberOfClicks.Click++;
    }
}
