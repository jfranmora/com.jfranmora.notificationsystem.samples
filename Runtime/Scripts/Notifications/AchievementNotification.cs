using TMPro;
using UnityEngine;
using UnityEngine.UI;

public struct AchievementNotificationData : INotificationData
{
    public string Text { get; }
    public Sprite Sprite { get; }

    public AchievementNotificationData(string text, Sprite sprite)
    {
        Text = text;
        Sprite = sprite;
    }
}

public class AchievementNotification : BaseExampleNotification<AchievementNotificationData>
{
    [Header("References")]
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI text;

    protected override void ShowInternal(AchievementNotificationData notificationData)
    {
        base.ShowInternal(notificationData);

        text.text = notificationData.Text;
        image.sprite = notificationData.Sprite;
    }
}
