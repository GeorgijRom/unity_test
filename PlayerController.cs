using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public Camera cam;
    private Vector2 mousePos;
    public int health = 4;
    public int numOfHeart;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVelocity.x = Input.GetAxisRaw("Horizontal");
        moveVelocity.y = Input.GetAxisRaw("Vertical");
        mousePos= cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        if (health <=0)
        {
            panel.SetActive(true);
            Destroy(gameObject);
        }
        if (health >numOfHeart)
        {
            health = numOfHeart;
        }
        for (int i = 0; i < hearts.Length ; i++ )
        {
            if (i< Mathf.RoundToInt(health))
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHeart)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        rb.MovePosition(rb.position + moveVelocity * speed * Time.fixedDeltaTime);
        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x)* Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

}
