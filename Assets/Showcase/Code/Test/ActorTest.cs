using MADLEngine;
using Unity.VisualScripting;
using UnityEngine;

public class ActorTest : MonoBehaviour
{
    public Scene2DActor Actor1;
    public Scene2DActor Actor2;
    void Start()
    {
        Actor1.CollisionEnter += CollisionEnterAction;
        Actor1.CollisionExit += CollisionExitAction;
        Actor1.CollisionStay += CollisionStayAction;
        Actor1.TriggerEnter += TriggerEnterAction;
        Actor1.TriggerExit += TriggerExitAction;
        Actor1.TriggerStay += TriggerStayAction;
        Actor1.BecameVisible += BecameVisible;
        Actor1.BecameInvisible += BecameInvisible;
        
        Actor2.CollisionEnter += CollisionEnterAction;
        Actor2.CollisionExit += CollisionExitAction;
        Actor2.CollisionStay += CollisionStayAction;
        Actor2.TriggerEnter += TriggerEnterAction;
        Actor2.TriggerExit += TriggerExitAction;
        Actor2.TriggerStay += TriggerStayAction;
        Actor2.BecameVisible += BecameVisible;
        Actor2.BecameInvisible += BecameInvisible;
    }
    
    private void CollisionEnterAction(Scene2DActor actor, Collision2D collider)
    {
        Debug.Log($"{actor.gameObject.name} enter {collider.gameObject.name}");
    }
    private void CollisionExitAction(Scene2DActor actor, Collision2D collider)
    {
        Debug.Log($"{actor.gameObject.name} exit {collider.gameObject.name}");
    }
    private void CollisionStayAction(Scene2DActor actor, Collision2D collider)
    {
        Debug.Log($"{actor.gameObject.name} stay {collider.gameObject.name}");
    }
    private void TriggerEnterAction(Scene2DActor actor, Collider2D collider)
    {
        Debug.Log($"{actor.gameObject.name} enter trigger {collider.gameObject.name}");
    }
    private void TriggerExitAction(Scene2DActor actor, Collider2D collider)
    {
        Debug.Log($"{actor.gameObject.name} exit trigger {collider.gameObject.name}");
    }
    private void TriggerStayAction(Scene2DActor actor, Collider2D collider)
    {
        Debug.Log($"{actor.gameObject.name} stay trigger {collider.gameObject.name}");
    }
    private void BecameVisible(Scene2DActor actor)
    {
        Debug.Log($"{actor.gameObject.name} visible");
    }
    private void BecameInvisible(Scene2DActor actor)
    {
        Debug.Log($"{actor.gameObject.name} invisible");
    }
}
