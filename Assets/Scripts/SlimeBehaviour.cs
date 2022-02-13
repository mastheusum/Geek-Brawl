using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBehaviour : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed = 3;

    Rigidbody2D rig;
    Animator anim;
    Vector3 direction = Vector3.zero;

    float life = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.transform.position, transform.position) > 14)
        {
            gameObject.isStatic = true;
        }
        else if (Vector3.Distance(target.transform.position, transform.position) > 6 && direction == Vector3.zero)
        {
            gameObject.isStatic = false;
            direction.x = Random.Range(-10f, 10f);
            direction.y = Random.Range(-10f, 10f);
            Invoke("ResetDirection", 2f);
        }
        else if ( !(Vector3.Distance(target.transform.position, transform.position) > 6) )
        {
            gameObject.isStatic = false;
            direction = GetTargetDirection();
        }
        direction.Normalize();
        anim.SetBool("IsMoving", direction != Vector3.zero);
        if (!anim.GetBool("Dead"))
            rig.MovePosition(transform.position + direction * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            collisionInfo.gameObject.SendMessage("RecieveDamage", 10);
            anim.SetBool("Dead", true);
        }
    }

    public void RecieveDamage(float value)
    {
        life -= value;
        if (life <= 0)
        {
            anim.SetBool("Dead", true);
            GameManager.instance.AddScore(1);
        }
    }

    public void SelfDestroy()
    {
        Destroy(gameObject);
    }

    Vector3 GetTargetDirection() {
        Vector3 dir = target.transform.position - transform.position;
        dir.z = 0;
        return dir;
    }

    void ResetDirection()
    {
        direction = Vector3.zero;
    }
}
