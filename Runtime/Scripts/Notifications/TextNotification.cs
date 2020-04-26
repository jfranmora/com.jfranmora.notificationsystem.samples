using TMPro;
using UnityEngine;

public struct TextNotificationData : INotificationData
{
	public string Text { get; }

	public TextNotificationData(string text)
	{
		Text = text;
	}
}

public class TextNotification : BaseExampleNotification<TextNotificationData>
{
	[Header("References")]
	[SerializeField] private TextMeshProUGUI _text;

	protected override void ShowInternal(TextNotificationData notificationData)
	{
		base.ShowInternal(notificationData);
		
		_text.text = notificationData.Text;
	}
}