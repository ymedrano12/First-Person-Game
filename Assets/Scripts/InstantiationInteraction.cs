using System.Security.Cryptography;
using UnityEngine;

public class InstantiationInteraction : MonoBehaviour
{
    private GameObject mainCamera;
    [SerializeField] private GameObject projectile, ProjectileSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = FindFirstObjectByType<Camera>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(projectile, ProjectileSpawn.transform.position, mainCamera.transform.rotation);
        }
    }
}
