using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private MapManager mapManager;

    [SerializeField] private float speed = 1;
    [SerializeField] private Joystick joystick;
    [SerializeField] private Sprite[] sprites;

    private SpriteRenderer sr;
    private CapsuleCollider2D cc;

    private void Awake()
    {
        cc = GetComponent<CapsuleCollider2D>();
        sr = GetComponent<SpriteRenderer>();
        mapManager = FindObjectOfType<MapManager>();
    }

    private void Update()
    {
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || (((joystick.Horizontal > 0.2f) || (joystick.Horizontal < -0.2f))))
        if ((joystick.Vertical > 0.2f) || (joystick.Vertical < -0.2f))
            OnInputVertical();
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || (((joystick.Horizontal > 0.2f) || (joystick.Horizontal < -0.2f))))
        if ((joystick.Horizontal > 0.2f) || (joystick.Horizontal < -0.2f))
            OnInputHorisontal();
        //if (Input.GetKey(KeyCode.S))
        //    OnInputVertical();
        //if (Input.GetKey(KeyCode.D))
        //    OnInputHorisontal();

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.name == "bomb(Clone)")
        {
                Destroy(gameObject, .4f);
        }
    }

    private void OnInputHorisontal()
    {
        if (joystick.Horizontal > 0.01f)
        {
            sr.sprite = sprites[0];
        } else if (joystick.Horizontal < 0.01f)
        {
            sr.sprite = sprites[1];
        }
        //if(!(cc.direction == CapsuleDirection2D.Horizontal))
        //{
        //    cc.direction = CapsuleDirection2D.Horizontal;
        //    //Direction();
        //}
        Vector3 dir = transform.right * joystick.Horizontal;
        //Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        //sr.flipX = dir.x < 0.0f;

    }
    private void OnInputVertical()
    {
        if (joystick.Vertical > 0.01f)
        {
            sr.sprite = sprites[3];
        }
        else if (joystick.Vertical < 0.01f)
        {
            sr.sprite = sprites[2];
        }
        //if (!(cc.direction == CapsuleDirection2D.Vertical))
        //{
        //    cc.direction = CapsuleDirection2D.Vertical;
        //    //Direction();
        //}
        Vector3 dir = transform.up * joystick.Vertical;
        //Input.GetAxis("Vertical");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }
    //private void Direction()
    //{
    //    //Debug.Log((int)cc.direction);
    //    Vector2 offset = new Vector2(0.45f, 0.45f); 
    //        //cc.offset;
    //    Vector2 size = new Vector2(0.45f, 0.45f);
    //    //cc.size;
    //    //cc.offset = offset;
    //    //new Vector2(offset.y, offset.x);
    //    cc.size = size;
    //        //new Vector2(size.y, size.x);
    //}

}
