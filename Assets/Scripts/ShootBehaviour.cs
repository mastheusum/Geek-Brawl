using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehaviour : MonoBehaviour
{
    public Rigidbody2D rig;
    public float shootForce = 3;

    BoxCollider2D coll;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        /*
        Assim que o objeto é criado já é preparado para ser destruído
        */
        Invoke("SelfDestroy", 3.0f);
        
        // pegamos um vertor que aponte na direção do mouse
        dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        dir.Normalize();
        // fazemos o calculo, com base nos eixos X e Y qual o ângulo/direção desse vetor em graus
        float rot_z = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot_z);
        
        // aplicaamos um impulso ao disparo logo que ele está pronto na cena
        rig.AddForce(transform.right * shootForce, ForceMode2D.Impulse);
    }

    void SelfDestroy() {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        rig.velocity = Vector2.zero;
        rig.angularVelocity = 0;
        coll.enabled = false;
        if (other.gameObject.tag == "Slime")
        {
            if ( other.gameObject.GetComponent<SlimeBehaviour>().RecieveDamage(50) )
            {
                GameManager.instance.AddScore(1);
            }
        }
    }
}
