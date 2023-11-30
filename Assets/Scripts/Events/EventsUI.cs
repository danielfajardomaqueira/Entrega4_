using UnityEngine;
using TMPro;

public class EventsUI : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private TextMeshProUGUI distanceText;
    private string defaultText = "Distance to Enemy";

    #endregion

    private void Awake()
    {
        InitializeText();
    }


    void OnEnable()
    {
        EventsGameManager.OnEscapeKeyPressed += InitializeText;
        EventsGameManager.OnEnterKeyPressed += UpdateText;
    }

    void OnDisable()
    {
        EventsGameManager.OnEscapeKeyPressed -= InitializeText;
        EventsGameManager.OnEnterKeyPressed -= UpdateText;
    }
    private void InitializeText()
    {
        distanceText.text = defaultText;
    }

    private void UpdateText()
    {
        float distance = EventsPlayerController.Instance.DistanceToEnemy();
        distanceText.text = distance.ToString("F2");
    }
}
