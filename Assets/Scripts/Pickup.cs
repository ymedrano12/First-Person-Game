using System.Runtime.CompilerServices;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Pickup trigger entered");
            FindFirstObjectByType<ScoreUI>().IncreaseScore();
            Destroy(gameObject);
        }
    }
}
