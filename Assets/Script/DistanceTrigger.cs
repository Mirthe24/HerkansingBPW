using UnityEngine;

public class DistanceTrigger : MonoBehaviour
{
    public Transform target;  // The object to check the distance to
    public float triggerDistance = 5.0f;  // The distance at which the animation should be triggered
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check the distance between this object and the target
        if (Vector3.Distance(transform.position, target.position) < triggerDistance)
        {
            animator.SetBool("IsClose", true);  // Trigger the animation
        }
        else
        {
            animator.SetBool("IsClose", false);  // Reset the animation
        }
    }
}
