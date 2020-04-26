using UnityEngine;

public class NotificationTester : MonoBehaviour
{
	private int count;
	
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			NotificationManager.ShowNotification<TextNotification>(new TextNotificationData($"Notification {count++}"), 5);
		}
	}
}
