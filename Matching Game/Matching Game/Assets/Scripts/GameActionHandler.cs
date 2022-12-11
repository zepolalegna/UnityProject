using System;
using UnityEngine;
using UnityEngine.Events;
public class GameActionHandler : MonoBehaviour
{
   public GameAction GameActionObj;
   public UnityEvent onRaiseEvent;

   private void Start()
   {
      GameActionObj.raise += Raise;
      
   }

   private void Raise()
   {
      onRaiseEvent.Invoke();
   }
}
