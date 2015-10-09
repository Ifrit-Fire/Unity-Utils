using UnityEngine;

namespace Sawyer.Utils {
	public static class Timber {
		public const int PERCISION = 3;

		/** 
		* <summary>
		* Logs various details on a Collider. Collider not required if providing the GameObject and vice versa. Optionally,
		* use the percision param to adjust string output.
		* </summary>
		*/
		public static void LogCollider(Collider collider = null, GameObject gameObject = null, int percision = PERCISION) {
			if (!collider) {
				if (gameObject) {
					collider = gameObject.GetComponent<Collider>();
				} else {
					Debug.Log("No Collider or GameObject detected");
					return;
				}
			}
			string strPercision = "F" + percision;
			Debug.Log("Collider: " + collider.GetInstanceID() + "\nBounds " + collider.bounds.ToString(strPercision) +
				"\nMax " + collider.bounds.max.ToString(strPercision) + " Min " + collider.bounds.min.ToString(strPercision) +
				" Size " + collider.bounds.size.ToString(strPercision));
		}

		/** 
		 * <summary>
		 * Logs various details on a Renderer. Renderer not required if providing the GameObject and vice versa. Optionally,
		 * use the precision param to adjust the string output.
		 * </summary> 
		 */
		public static void LogRenderer(Renderer renderer = null, GameObject gameObject = null, int percision = PERCISION) {
			if (!renderer) {
				if (gameObject) {
					renderer = gameObject.GetComponent<Renderer>();
				} else {
					Debug.Log("No Renderer or GameObject detected");
					return;
				}
			}
			string strPercision = "F" + percision;
			Debug.Log("Renderer: " + renderer.GetInstanceID() + "\nBounds " + renderer.bounds.ToString(strPercision) +
				"\nMax " + renderer.bounds.max.ToString(strPercision) + " Min " + renderer.bounds.min.ToString(strPercision) +
				" Size " + renderer.bounds.size.ToString(strPercision));
		}

		/** 
		 * <summary>
		 * Logs various details on a Transform. Transform not required if providing the GameObject and vice versa. Optionally,
		 * use the precision param to adjust the string output.
		 * </summary>
		 */
		public static void LogTransform(Transform transform = null, GameObject gameObject = null, int percision = PERCISION) {
			if (!transform) {
				if (gameObject) {
					transform = gameObject.GetComponent<Transform>();
				} else {
					Debug.Log("No Renderer or GameObject detected");
					return;
				}
			}
			string strPercision = "F" + percision;
			Debug.Log("Transform: " + transform.GetInstanceID() + " Children " + transform.childCount +
				"\nGlobal Pos " + transform.position.ToString(strPercision) + " Local Pos " + transform.localPosition.ToString(strPercision) +
				"\nGlobal Rot " + transform.rotation.ToString(strPercision) + " Local Pos " + transform.localRotation.ToString(strPercision) +
				"\nLossy Scale " + transform.lossyScale.ToString(strPercision) + " Local Scale " + transform.localScale.ToString(strPercision));
		}

		/**
		 * <summary>
		 * Logs various details on a Vector.  Optionally, use the precision param to adjust the string output.
		 * </summary>
		 */
		public static void LogVector3(Vector3 vector, int percision = PERCISION) {
			string strPercision = "F" + percision;
			Debug.Log("Vector: " + vector.ToString(strPercision) + " Normal " + vector.normalized.ToString(strPercision) +
				"\nMag " + vector.magnitude.ToString(strPercision) + " Sqr Mag " + vector.sqrMagnitude.ToString(strPercision));
		}
	}
}