using UnityEngine;

public class FallProtectionZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "zone")
        {
            collision.transform.position = new Vector3(0, 0.1f, 0);
        }
    }
}
