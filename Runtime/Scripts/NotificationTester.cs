using UnityEngine;

public class NotificationTester : MonoBehaviour
{
	private const float NormalNotificationDuration = 5f;

	[SerializeField] private Sprite achievementSprite;

	private int count;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			TriggerTextNotification();
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			TriggerAchievementNotification();
		}
	}

	private void TriggerTextNotification()
	{
		NotificationManager.ShowNotification<TextNotification>(
			new TextNotificationData($"Notification {count++}"),
			NormalNotificationDuration);
	}

	private void TriggerAchievementNotification()
	{
		NotificationManager.ShowNotification<AchievementNotification>(
			new AchievementNotificationData($"Notification {count++}", achievementSprite),
			NormalNotificationDuration);
	}
}