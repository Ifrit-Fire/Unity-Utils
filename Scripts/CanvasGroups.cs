using UnityEngine;

namespace Sawyer.Utils {

	public static class CanvasGroups {
		public static void Hide(this CanvasGroup canvasGroup) {
			canvasGroup.interactable = canvasGroup.blocksRaycasts = false;
			canvasGroup.alpha = 0.0f;
		}

		public static void Show(this CanvasGroup canvasGroup) {
			canvasGroup.interactable = canvasGroup.blocksRaycasts = true;
			canvasGroup.alpha = 1.0f;
		}
	}
}