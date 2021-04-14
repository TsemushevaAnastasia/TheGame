using UnityEngine;


public class PlayerCntrl : MonoBehaviour
{
    public float runSpeed = 30f;
    float horizontalMove = 0f;
    private Rigidbody2D rb;
    public Animator animator;

    private bool faceRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        rb.MovePosition(rb.position + Vector2.right * moveX * runSpeed * Time.deltaTime);

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove)); // штука для анимации. переменная "speed" - один из параметров в аниматоре

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector2.up * 8000);

        if (moveX > 0 && !faceRight)
            flip();
        else if (moveX < 0 && faceRight)
            flip();
    }

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
