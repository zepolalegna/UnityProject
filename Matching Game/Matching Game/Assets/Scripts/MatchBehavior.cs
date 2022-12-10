using UnityEngine;
using UnityEngine.Events;
public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
           matchEvent.Invoke();
        }
        else
        {
           noMatchEvent.Invoke();
        }
    }
}