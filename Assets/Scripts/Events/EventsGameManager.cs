using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    // HERE YOU WILL HAVE TO DECLARE AND INVOKE THE EVENTS

    public delegate void KeyPressAction();
    public static event KeyPressAction OnEnterKeyPressed;
    public static event KeyPressAction OnEscapeKeyPressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (OnEnterKeyPressed != null)
                OnEnterKeyPressed();
            Debug.Log("Enter");

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (OnEscapeKeyPressed != null)
                OnEscapeKeyPressed();
            Debug.Log("Escape");
        }
    }

}
