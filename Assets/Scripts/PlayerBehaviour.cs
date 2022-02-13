using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float maxLife = 100;
    public float moveSpeed = 1;
    public Rigidbody2D rig;
    public GameObject shoot;

    public HUDManager hud;
    
    Animator anim;
    SpriteRenderer sprite;

    float life;
    float moveX;
    float moveY;
    // Start is called before the first frame update
    void Start()
    {
        life = maxLife;
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        Vector3 mousePos = Input.mousePosition;
     
        anim.SetBool("IsMoving", moveX != 0 || moveY != 0);
        // Se a posição do mouse na tela for menor que a posição do Player na tela então a imagem deve ser invertida horizontalmente
        sprite.flipX = mousePos.x < Camera.main.WorldToScreenPoint(transform.position).x;
        
        rig.MovePosition(transform.position + new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime);

        if (Input.GetAxisRaw("Fire1") != 0) {
            anim.SetTrigger("Attack");
        }
    }

    public void RecieveDamage(float value)
    {
        life -= value;
        hud.SendMessage("UpdateHealt", life / maxLife);
        // anim.SetBool("Dead", life <= 0);
    }

    public void SpawnShoot() 
    {
        Instantiate(shoot, transform.position, Quaternion.identity);
    }

    public void SetAttacking() 
    {
        anim.ResetTrigger("Attack");
    }
}
