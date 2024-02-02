using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public Transform target;
    public float speed = 1;
    [SerializeField]
    public bool playing = true;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            //move to target
            Vector3 dir = (target.position - transform.position).normalized;
            transform.position += dir * speed * Time.deltaTime;

            //when arrived,
            if (Vector3.Distance(transform.position, target.position) < 0.01f)
            {
                //stop
                playing = false;
            }
        }
        //update animator
        animator?.SetBool("walking", playing);
    }
}
