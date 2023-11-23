using UnityEngine;

public class Player : MonoSingleton<Player>
{
    public Rigidbody rb;
    private  static Vector3 playerStartPosVector;
    [SerializeField] private float moveForce = 500f;
    private float horSpeed;
    private float vertSpeed;

    private void Awake()
    {
        playerStartPosVector = GetComponentInParent<Rigidbody>().position;
    }

    public void RestartPosition()
    {
        this.enabled = true;
        GetComponentInParent<Rigidbody>().position = playerStartPosVector;
    }

    private void FixedUpdate()
    {
        horSpeed = Input.GetAxis("Horizontal") * moveForce * Time.deltaTime;
        vertSpeed = Input.GetAxis("Vertical") * moveForce * Time.deltaTime;

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.forward * vertSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.right * horSpeed);
        }
    }
}
