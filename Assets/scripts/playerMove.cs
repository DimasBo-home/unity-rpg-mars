using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerMove : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField]
    private GameObject zproia;
    [SerializeField]
    public static bool is_visible_zproia = false;
    private Ray ray;
    private RaycastHit hit;
    private Animator animator;
    private Vector3 movePosition;
    [SerializeField]
    private AudioClip clipAtaka;
    [SerializeField]
    private AudioClip clipStep;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            movePosition = Input.mousePosition;
            ray = Camera.main.ScreenPointToRay(movePosition);

            if (Physics.Raycast(ray, out hit, 1000))
            {
                agent.SetDestination(hit.point);
            }
        }
        animator.SetBool("is_run", (int)agent.velocity.magnitude > 0);
        zproia.SetActive(is_visible_zproia);
        if (Input.GetMouseButtonDown(1))
        {
            print(clipAtaka);
            audio_control.playClip(clipAtaka);
            animator.SetTrigger("is_ataka");
        }
    }
    void Step()
    {
        audio_control.playClip(clipStep);
    }
}