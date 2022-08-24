using UnityEngine;
using UnityEngine.AI;

public class AgentTarget : MonoBehaviour
{
    public Transform Target;
    private NavMeshAgent _agent;

    // Start is called before the first frame update
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        _agent.destination = Target.position;
    }

}
