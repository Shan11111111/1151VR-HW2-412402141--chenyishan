using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    public GameObject startPanel;
    public AudioSource bgm;

    void Start()
    {
        // 顯示開始畫面
        startPanel.SetActive(true);

        // 遊戲先暫停
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        // 關閉開始畫面
        startPanel.SetActive(false);

        // 開始遊戲
        Time.timeScale = 1f;

        // 播放背景音樂
        if (bgm != null)
        {
            bgm.Play();
        }
    }
}