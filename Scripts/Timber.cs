using UnityEngine;

namespace Sawyer.Utils {
	public static class Timber {
		public const int PERCISION = 3;

		/** 
		* <summary>
		* Logs various details on a Collider from the provided GameObject. Optionally, use the percision param to adjust string output.
		* </summary>
		*/
		public static void LogCollider(this GameObject self, int percision = PERCISION) {
			Collider collider = self.GetComponent<Collider>();
			if (collider) {
				collider.Log(percision);
			} else {
				Debug.LogWarning("No Collider detected with GameObject " + self.GetInstanceID());
				return;
			}
		}

		/** 
		* <summary>
		* Logs various details on self. Optionally, use the percision param to adjust string output.
		* </summary>
		*/
		public static void Log(this Collider self, int percision = PERCISION) {
			string strPercision = "F" + percision;
			Debug.Log("Collider: " + self.GetInstanceID() + "\nBounds " + self.bounds.ToString(strPercision) +
				"\nMax " + self.bounds.max.ToString(strPercision) + " Min " + self.bounds.min.ToString(strPercision) +
				" Size " + self.bounds.size.ToString(strPercision) + "\nTrigger " + self.isTrigger +
				" Enabled " + self.enabled);
		}

		/** 
		 * <summary>
		 * Logs various details on a Renderer from the provided GameObject. Optionally, use the precision param to adjust the string output.
		 * </summary> 
		 */
		public static void LogRenderer(this GameObject self, int percision = PERCISION) {
			Renderer renderer = self.GetComponent<Renderer>();
			if (renderer) {
				renderer.Log(percision);
			} else {
				Debug.LogError("No Renderer detected with GameObject " + self.GetInstanceID());
				return;
			}
		}

		/** 
		* <summary>
		* Logs various details on self. Optionally, use the percision param to adjust string output.
		* </summary>
		*/
		public static void Log(this Renderer self, int percision = PERCISION) {
			string strPercision = "F" + percision;
			Debug.Log("Renderer: " + self.GetInstanceID() + "\nBounds " + self.bounds.ToString(strPercision) +
				"\nMax " + self.bounds.max.ToString(strPercision) + " Min " + self.bounds.min.ToString(strPercision) +
				" Size " + self.bounds.size.ToString(strPercision) + "\nVisible " + self.isVisible +
				" Enabled " + self.enabled);
		}

		/** 
		 * <summary>
		 * Logs various details on a Transform from the provide GameObject. Optionally, use the precision param to adjust the string output.
		 * </summary>
		 */
		public static void LogTransform(this GameObject self, int percision = PERCISION) {
			Transform transform = self.GetComponent<Transform>();
			if (transform) {
				transform.Log(percision);
			} else {
				Debug.LogError("No Transform detected with GameObject " + self.GetInstanceID());
				return;
			}
		}

		/** 
		* <summary>
		* Logs various details on self. Optionally, use the percision param to adjust string output.
		* </summary>
		*/
		public static void Log(this Transform self, int percision = PERCISION) {
			string strPercision = "F" + percision;
			Debug.Log("Transform: " + self.GetInstanceID() + " Children " + self.childCount +
				"\nGlobal Pos " + self.position.ToString(strPercision) + " Local Pos " + self.localPosition.ToString(strPercision) +
				"\nGlobal Rot " + self.rotation.ToString(strPercision) + " Local Pos " + self.localRotation.ToString(strPercision) +
				"\nLossy Scale " + self.lossyScale.ToString(strPercision) + " Local Scale " + self.localScale.ToString(strPercision));
		}

		/** 
		* <summary>
		* Logs various details on self. Optionally, use the percision param to adjust string output.
		* </summary>
		*/
		public static void Log(this Vector2 self, int percision = PERCISION) {
			string strPercision = "F" + percision;
			Debug.Log("Vector2: " + self.ToString(strPercision) + " Normal " + self.normalized.ToString(strPercision) +
				"\nMag " + self.magnitude.ToString(strPercision) + " Sqr Mag " + self.sqrMagnitude.ToString(strPercision));
		}

		/** 
		* <summary>
		* Logs various details on self. Optionally, use the percision param to adjust string output.
		* </summary>
		*/
		public static void Log(this Vector3 self, int percision = PERCISION) {
			string strPercision = "F" + percision;
			Debug.Log("Vector3: " + self.ToString(strPercision) + " Normal " + self.normalized.ToString(strPercision) +
				"\nMag " + self.magnitude.ToString(strPercision) + " Sqr Mag " + self.sqrMagnitude.ToString(strPercision));
		}

		/** 
		* <summary>
		* Logs various details on self. Optionally, use the percision param to adjust string output.
		* </summary>
		*/
		public static void Log(this Vector4 self, int percision = PERCISION) {
			string strPercision = "F" + percision;
			Debug.Log("Vector4: " + self.ToString(strPercision) + " Normal " + self.normalized.ToString(strPercision) +
				"\nMag " + self.magnitude.ToString(strPercision) + " Sqr Mag " + self.sqrMagnitude.ToString(strPercision));
		}
	}
}