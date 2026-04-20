using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float timer = 5f;
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 5000f);
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            Destroy(gameObject);
        }
    }

   
}
