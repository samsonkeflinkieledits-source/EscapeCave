using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] public Transform player;
    [SerializeField] public Vector3 offset = new Vector3(0, 3, -6);
    [SerializeField] public float smoothSpeed = 5f;


   void LateUpdate()
    {
        Vector3 targetPosition = player.position + offset;

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );

        transform.LookAt(player);
    }

}
