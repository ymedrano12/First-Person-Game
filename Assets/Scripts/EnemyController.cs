
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float playerDistance;
    [SerializeField] private float chaseRange = 3f, attackRange = 1f, speed = 2.0f;
    private GameObject player;
    private Vector3 idlePos = Vector3.zero;
    public float damage;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        idlePos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var playerLoc = player.transform.position;
        playerDistance = Vector3.Distance(playerLoc, transform.position);
        if(playerDistance < attackRange)
        {
            Debug.Log("Attacking player");
            Debug.Log("Enemy trigger entered");
            FindFirstObjectByType<PlayerStats>().TakeDamage(5f);
        }
        else if (playerDistance < chaseRange)
        {
            Debug.Log("Chasing player");
            transform.LookAt(playerLoc, transform.up);

            var moveVector = transform.forward * Time.deltaTime * speed;
            var correctedVector = new Vector3(moveVector.x, 0f, moveVector.z);
            transform.position += correctedVector;

        }
        else if(Vector3.Distance(transform.position, idlePos) > .25f)
        {
            Debug.Log("Going to idle");
            transform.LookAt(idlePos);
            var moveVector = transform.forward * Time.deltaTime * speed;
            transform.position += moveVector;
        }
    }
}
