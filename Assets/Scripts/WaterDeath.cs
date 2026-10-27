using UnityEngine;
using UnityEngine.SceneManagement;


public class WaterDeath : MonoBehaviour
{

    public float MoveSpeed = 1f;

    void Update()
    {
        transform.position += new Vector3(0, MoveSpeed * Time.deltaTime, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }
    }

}
