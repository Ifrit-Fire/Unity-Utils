using UnityEngine;

namespace Sawyer.Utils {
	public static class GameObjects {
		/**
		 * <summary>
		 * Returns /self/ or new instance if prefab.
		 * </summary>
		 */
		public static GameObject InstantiateCheck(this GameObject self) {
			return (self.activeInHierarchy) ? self : Object.Instantiate(self);
		}
	}
}

