using System.Collections;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    public Transform target;
    float speed = 5;
    Vector3[] path;
    int targetIndex;
    Vector3 lastKnownTargetPosition = Vector3.zero;

    private void Start()
    {
        StartCoroutine("UpdatePathCheck");
    }

    IEnumerator UpdatePathCheck()
    {
        if (lastKnownTargetPosition != target.position)
        {
            Debug.Log("Requesting new path.");
            lastKnownTargetPosition = target.position;
            PathQueue.RequestPath(transform.position, target.position, OnPathFound);
        }

        yield return new WaitForSeconds(5);
        StartCoroutine("UpdatePathCheck");
    }

    public void OnPathFound(Vector3[] newPath, bool pathSuccessful)
    {
        StopCoroutine("FollowPath");

        if (pathSuccessful)
        {
            path = newPath;
            targetIndex = 0;
            StartCoroutine("FollowPath");
        }
    }

    IEnumerator FollowPath()
    {
        Debug.Log("Waypoints in path - Follow Path: " + path.Length);

        Vector3 currentWaypoint = path[0];

        while (true)
        {
            if (transform.position == currentWaypoint)
            {
                targetIndex++;
                if (targetIndex >= path.Length)
                {
                    Debug.Log("End of path reached.");
                    yield break;
                }

                currentWaypoint = path[targetIndex];
            }

            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint, speed * (Time.deltaTime));
            yield return null;
        }
    }
}
