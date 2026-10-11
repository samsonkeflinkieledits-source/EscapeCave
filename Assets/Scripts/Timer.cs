using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{

    public TMP_Text timerText;
    public float timeRemaining = 60f;

    public void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time: " +
                Mathf.CeilToInt(timeRemaining);
        }
        else
        {
            timerText.text = "Time: 0";
            SceneManager.LoadScene(1);
        }
    }

}
