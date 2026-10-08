using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject finishPanel;

    // 終點音效
    public AudioClip finishSound;

    private AudioSource audioSource;
    private bool finished = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !finished)
        {
            finished = true;

            // 播放終點音效
            if (finishSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(finishSound);
            }

            // 顯示過關介面
            finishPanel.SetActive(true);

            // 暫停遊戲
            Time.timeScale = 0f;
        }
    }

    public void RestartGame()
    {
        // 恢復時間
        Time.timeScale = 1f;

        // 重新載入目前場景
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}