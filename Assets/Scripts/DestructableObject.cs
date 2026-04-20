using System.Numerics;
using UnityEngine;

public class DestructableObject : MonoBehaviour
{
    [SerializeField] private GameObject destroyedObject;
    public void DestroyObject()
    {
        Instantiate(destroyedObject, transform.position, transform.rotation);
        DestroyObject(gameObject);
    }
}
