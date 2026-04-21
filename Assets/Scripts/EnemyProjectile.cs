using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float damage;
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         other.GetComponent<PlayerStats>().TakeDamage(damage);
    //         Destroy(gameObject);
    //     }
    // }
}
