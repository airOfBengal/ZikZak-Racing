using UnityEngine;

public class Platform : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnBecameInvisible()
    {
        rb.isKinematic = false;
    }
}
