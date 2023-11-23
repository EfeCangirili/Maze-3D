using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform playerTransform;
    public Vector3 cameraOffset;


    // Update is called once per frame
    void Update()
    {
        Rotate();
        transform.position = playerTransform.position + cameraOffset;
        transform.LookAt(playerTransform.position);        
    }

    public void Rotate()
    {
        cameraOffset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 4f, Vector3.up) * cameraOffset;
    }
}
