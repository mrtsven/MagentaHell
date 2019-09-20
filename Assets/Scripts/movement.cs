using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public UnityEngine.Camera cam;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                agent.SetDestination(hit.point);
            }
        }

        if(GameObject.FindGameObjectsWithTag("Limb").Length == 6) {
            Debug.Log("Fly away to magenta heaven");
            rb.MovePosition(transform.position + transform.up * Time.fixedDeltaTime);
        }
    }
}
