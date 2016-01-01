using UnityEngine;

namespace Sawyer.Utils {
	public static class GameObjects {
		/**
		 * <summary>
		 * Creates a new instance of itself if not instantiated yet.
		 * </summary>
		 */
		public static void Instantiate(this GameObject self) {
			if (!self.activeInHierarchy) {
				Object.Instantiate(self);
			}
		}
	}
}

