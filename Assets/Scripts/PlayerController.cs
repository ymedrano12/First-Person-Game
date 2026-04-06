using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;



public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private Camera mainCamera;

    private float yRotation = 0f;
    private float xRotation = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse movmt along x,y axis
        var mouseY = Input.GetAxis("Mouse Y");
        var mouseX = Input.GetAxis("Mouse X");

        // adjust stored rotation
        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation,-90f, 90f);
        xRotation += mouseX;


        //rotate based on stored rotation
        transform.rotation = Quaternion.Euler(new Vector3(0f, xRotation, 0f));

        mainCamera.transform.rotation = Quaternion.Euler(new Vector3(yRotation, xRotation, 0f));


        var vertInput = Input.GetAxis("Vertical"); // vertical input a/d keys
        var horzInput = Input.GetAxis("Horizontal"); // horizontal input w/s keys

        //get directional vectors based on player orientation and input
        var forwardDir = transform.forward * vertInput * Time.deltaTime * speed;
        var sideDir = transform.right * horzInput * Time.deltaTime * speed;

        //determine movement from forward and side 
        var moveVector = forwardDir + sideDir;

        // use char controller 
        characterController.Move(moveVector);
    }
}
