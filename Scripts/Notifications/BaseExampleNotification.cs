using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class BaseExampleNotification<T> : Notification<T>, IPointerClickHandler
	where T : INotificationData
{
	[SerializeField] private RectTransform _rect;
	[SerializeField] private CanvasGroup _canvasGroup;

	protected override void ShowInternal(T notificationData)
	{
		_canvasGroup.alpha = 0;
		_canvasGroup.DOFade(1f, .25f);
	}

	protected override void CloseInternal()
	{
		_canvasGroup.DOFade(0f, .25f).onComplete += OnClose;
	}

	private void OnClose()
	{
		Destroy(gameObject);
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		Close();
	}
}