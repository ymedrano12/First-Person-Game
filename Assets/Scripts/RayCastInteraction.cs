using System.Security.Cryptography;
using UnityEngine;

public class RayCastInteraction : MonoBehaviour
{
    private GameObject mainCamera;
    private int boxesHit = 0;
    private int boxesNeeded = 5;
    void Start()
    {
       mainCamera = FindFirstObjectByType<Camera>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if(Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit))
            {
                Debug.Log(hit.transform.name);
                  if(hit.transform.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rb))
                  {
                    rb.AddForce(mainCamera.transform.forward * 1000f);
                    boxesHit++;
                  }
                if(hit.transform.gameObject.TryGetComponent<DestructableObject>(out DestructableObject obj))
                {
                    boxesHit++;
                    obj.DestroyObject();
                }
                if(boxesHit >= boxesNeeded)
                {
                    FindFirstObjectByType<NewLevelTrigger>().NextLevel();
                }
            }
        }
    }
}
