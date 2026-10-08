using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 12f;
    public float downForce = 8f;

    public AudioClip jumpSound;

    private Rigidbody2D rb;
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;

    // 使用 Vector2 陣列儲存方向
    private Vector2[] directions =
    {
        new Vector2(-1f, 0f),   // 0：左
        new Vector2(1f, 0f),    // 1：右
        new Vector2(0f, 1f),    // 2：上
        new Vector2(0f, -1f)    // 3：下
    };

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Move();
        Jump();
        MoveDown();
    }

    void Move()
    {
        Vector2 moveDirection = Vector2.zero;

        // 往左
        if (Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection = directions[0];

            // 左走時翻面
            spriteRenderer.flipX = true;
        }

        // 往右
        if (Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection = directions[1];

            // 右走時恢復原方向
            spriteRenderer.flipX = false;
        }

        // 修改 X，保留原本 Y
        rb.linearVelocity = new Vector2(
            moveDirection.x * moveSpeed,
            rb.linearVelocity.y
        );
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) ||
            Input.GetKeyDown(KeyCode.UpArrow) ||
            Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 jumpDirection = directions[2];

            // 保留 X，修改 Y 為向上速度
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                jumpDirection.y * jumpForce
            );

            // 播放跳躍音效
            if (jumpSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(jumpSound);
            }
        }
    }

    void MoveDown()
    {
        if (Input.GetKeyDown(KeyCode.S) ||
            Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector2 downDirection = directions[3];

            // 保留 X，讓 Y 變成向下速度
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                downDirection.y * downForce
            );
        }
    }
}