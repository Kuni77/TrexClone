using UnityEngine;
using UnityEngine.SceneManagement;

public class TresScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float velocity , rayonDetecteur;
    private bool peutSauter, estAusSol;
    public LayerMask coucheDeCollision;
    public Transform detecteur;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        estAusSol = Physics2D.OverlapCircle(detecteur.position, rayonDetecteur, coucheDeCollision);
        //Debug.Log(peutSauter);
        if (Input.GetButton("Jump") && estAusSol)
        {
            rb.velocity = Vector2.up * velocity;
        }
        if (Score.score % 100 == 0)
            MoveLeft.speed += 1;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(detecteur.position, rayonDetecteur);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (!collision.gameObject.tag.Equals("road"))
        { 
            SceneManager.LoadScene("Menu"); 
            HighScore hs = new HighScore();
            hs.highScore();
        }

    }
}
