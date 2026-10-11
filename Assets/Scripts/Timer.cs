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
            timerText.text = Mathf.CeilToInt(timeRemaining) + " Seconds";
        }
        else
        {
            timerText.text = "0 Seconds";
            SceneManager.LoadScene(1);
        }
    }

}
