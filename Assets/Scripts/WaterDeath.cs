using UnityEngine;
using UnityEngine.SceneManagement;


public class WaterDeath : MonoBehaviour
{

    public float scaleSpeed = 1f;

    void Update()
    {
        transform.localScale += new Vector3(0, scaleSpeed * Time.deltaTime, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }
    }

}
