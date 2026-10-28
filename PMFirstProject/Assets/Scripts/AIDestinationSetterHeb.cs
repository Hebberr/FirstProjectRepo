using Pathfinding;
using Unity.VisualScripting;
using UnityEngine;

public class AIDestinationSetterHeb : MonoBehaviour
{
    public Transform target;
    IAstarAI ai;

    void OnEnable()
    {
        ai = GetComponent<IAstarAI>();
        if (ai != null) ai.onSearchPath += Update;
    }

    void OnDisable()
    {
        if (ai != null) ai.onSearchPath -= Update;
    }
    
    void Update()
    {
        if (target != null && ai != null && Vector3.Distance(transform.position, target.position) < 20) ai.destination = target.position;
    }
}
