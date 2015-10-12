using UnityEngine;

namespace Sawyer.Utils {
	public static class GameObjects {
		/**
		 * <summary>
		 * Returns /self/ or new instance if prefab.
		 * </summary>
		 */
		public static void Instantiate(this GameObject self) {
			if (!self.activeInHierarchy) {
				Object.Instantiate(self);
			}
		}
	}
}

