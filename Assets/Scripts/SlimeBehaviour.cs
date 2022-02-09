using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBehaviour : MonoBehaviour
{
    Animator anim;
    float life = 100;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool RecieveDamage(float value)
    {
        life -= value;
        anim.SetBool("Dead", life <= 0);
        return life <= 0;
    }

    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
