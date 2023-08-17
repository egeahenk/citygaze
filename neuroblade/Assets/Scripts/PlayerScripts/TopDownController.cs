using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownController : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    
    [Header("List of Directional Animations")]
    public List<Sprite> nSprites;
    public List<Sprite> neSprites;
    public List<Sprite> eSprites;
    public List<Sprite> seSprites;
    public List<Sprite> sSprites;
    [Header("Other")]
    public float walkSpeed;
    public float framRate;
    private Vector2 movementInput;

    float idleTime;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        Flip();
        
        SelectSprite();    
    }

    private void SelectSprite()
    {
        List<Sprite> directionSprites = GetSpriteDirection();

        if (directionSprites != null)
        {
            float playTime = Time.time - idleTime;
            int totalFrames = (int)(playTime * framRate);
            int frame = totalFrames % directionSprites.Count;

            spriteRenderer.sprite = directionSprites[frame]; 
        }
        else
        {
            idleTime = Time.time;
        }
    }


    private void FixedUpdate()
    {
        rb.velocity = movementInput * walkSpeed;
    }

    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
        
    }

    private void Flip()
    {
        bool playerHasSpeed = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;

        if(playerHasSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(rb.velocity.x), transform.localScale.y);
        }
    }

    List<Sprite> GetSpriteDirection()
    {
        List<Sprite> selectedSprite = null;
        if(movementInput.y > 0)//north
        {
            if(Mathf.Abs(movementInput.x) > 0)//east or west
            {
                selectedSprite = neSprites;
            }else
            {
                selectedSprite = nSprites;
            }
        }else if(movementInput.y <0)//south
        {
            if(Mathf.Abs(movementInput.x) > 0)//east or west
            {
                selectedSprite = seSprites;
            }else
            {
                selectedSprite = sSprites;
            }
        }else//neut
        {
            if(Mathf.Abs(movementInput.x) > 0)//east or west
            {
                selectedSprite = eSprites;
            }
        }
        return selectedSprite;
    }
}
