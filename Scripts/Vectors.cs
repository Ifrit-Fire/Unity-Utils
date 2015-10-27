using UnityEngine;

namespace Sawyer.Utils {

	public static class Vectors {
		/**
		* <summary>
		* Returns the scaling vector needed to go from one vector to another vector. Optionally provide a ScaleMode to determine
		* how the scaling should be performed.
		* </summary>
		*/
		public static Vector2 ScaleFromTo(Vector2 from, Vector2 to, ScaleMode scaleMode = ScaleMode.StretchToFill) {
			Vector2 scale = Vector2.one;
			scale.x = to.x / from.x;
			scale.y = to.y / from.y;

			switch (scaleMode) {
			case ScaleMode.ScaleAndCrop:
				scale.x = scale.y = Mathf.Max(scale.x, scale.y);
				break;

			case ScaleMode.ScaleToFit:
				scale.x = scale.y = Mathf.Min(scale.x, scale.y);
				break;

			case ScaleMode.StretchToFill:
				//Do nothing
				break;

			default:
				Debug.LogException(new System.NotImplementedException("The Received ScaleMode." + scaleMode.ToString() + " is not implemented."));
				break;
			}

			return scale;
		}

		/**
		* <summary>
		* Returns the scaling vector needed to go from one vector to another vector. Optionally provide a ScaleMode to determine
		* how the scaling should be performed.
		* </summary>
		*/
		public static Vector3 ScaleFromTo(Vector3 from, Vector3 to, ScaleMode scaleMode = ScaleMode.StretchToFill) {
			Vector3 scale = Vector3.one;
			scale.x = to.x / from.x;
			scale.y = to.y / from.y;
			scale.z = to.z / from.z;

			switch (scaleMode) {
			case ScaleMode.ScaleAndCrop:
				scale.x = scale.y = scale.z = Mathf.Max(scale.x, scale.y);
				break;

			case ScaleMode.ScaleToFit:
				scale.x = scale.y = scale.z = Mathf.Min(scale.x, scale.y);
				break;

			case ScaleMode.StretchToFill:
				//Do nothing
				break;

			default:
				Debug.LogException(new System.NotImplementedException("The Received ScaleMode." + scaleMode.ToString() + " is not implemented."));
				break;
			}

			return scale;
		}

		/**
		 * <summary>
		 * Returns the pointwise product (Hadamard product) of two vectors
		 * </summary>
		 */
		public static Vector2 PointwiseProduct(Vector2 one, Vector2 two) {
			return new Vector2(one.x * two.x, one.y * two.y);
		}

		/**
		 * <summary>
		 * Returns the pointwise product (Hadamard product) of a vector and 2 vector points
		 * </summary>
		 */
		public static Vector2 PointwiseProduct(Vector2 vector, float x, float y) {
			return new Vector2(vector.x * x, vector.y * y);
		}

		/**
		 * <summary>
		 * Returns the pointwise product (Hadamard product) of two vectors
		 * </summary>
		 */
		public static Vector3 PointwiseProduct(Vector3 one, Vector3 two) {
			return new Vector3(one.x * two.x, one.y * two.y, one.z * two.z);
		}

		/**
		 * <summary>
		 * Returns the pointwise product (Hadamard product) of a vector and 3 vector points
		 * </summary>
		 */
		public static Vector3 PointwiseProduct(Vector3 vector, float x, float y, float z) {
			return new Vector3(vector.x * x, vector.y * y, vector.z * z);
		}

		/**
		 * <summary>
		 * Returns the pointwise product (Hadamard product) of two vectors
		 * </summary>
		 */
		public static Vector4 PointwiseProduct(Vector4 one, Vector4 two) {
			return new Vector4(one.x * two.x, one.y * two.y, one.z * two.z, one.w * two.w);
		}

		/**
		 * <summary>
		 * Returns the pointwise product (Hadamard product) of a vector and 4 vector points
		 * </summary>
		 */
		public static Vector4 PointwiseProduct(Vector4 vector, float x, float y, float z, float w) {
			return new Vector4(vector.x * x, vector.y * y, vector.z * z, vector.w * w);
		}
	}
}