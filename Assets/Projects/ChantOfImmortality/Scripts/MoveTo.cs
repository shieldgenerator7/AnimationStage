using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public Transform target;
    public float speed = 1;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        //update animator
        animator?.SetBool("walking", enabled);
    }
    private void OnDisable()
    {
        //update animator
        animator?.SetBool("walking", enabled);
    }

    // Update is called once per frame
    void Update()
    {
        //move to target
        Vector3 dir = (target.position - transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;

        //when arrived,
        if (Vector3.Distance(transform.position, target.position) < 0.01f)
        {
            //stop
            enabled = false;
        }
    }
}
