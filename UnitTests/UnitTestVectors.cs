using UnityEngine;

namespace Sawyer.Utils.UnitTest {
	public class UnitTestVectors : MonoBehaviour {
		private Vector2Tests mVector2 = new Vector2Tests();
		private Vector3Tests mVector3 = new Vector3Tests();
		private Vector4Tests mVector4 = new Vector4Tests();

		void Start() {
			mVector2.Go();
			mVector3.Go();
			mVector4.Go();
		}

		private class Vector2Tests {
			private string mHeader = "Vector2Tests";

			public void Go() {
				TestPointwiseProduct();
			}

			private void TestPointwiseProduct() {
				string header = mHeader + ".TestPointwiseProduct\n";
				string output = header;
				Vector2 one = new Vector2(2.0f, 4.0f);
				Vector2 two = new Vector2(3.0f, 5.0f);
				Vector2 result = Vector2.zero;

				result = Vectors.PointwiseProduct(one, two);
				if (result.x != 6.0f || result.y != 20.0f)
					output += "#1 FAILED: " + result.ToString("F3") + "\n";
				result = Vector2.zero;

				result = Vectors.PointwiseProduct(one, two.x, two.y);
				if (result.x != 6.0f || result.y != 20.0f)
					output += "#2 FAILED: " + result.ToString("F3") + "\n";
				result = Vector2.zero;

				OutputResults(output, header);
			}
		}

		private class Vector3Tests {
			private string mHeader = "Vector3Tests";

			public void Go() {
				TestPointwiseProduct();
			}

			private void TestPointwiseProduct() {
				string header = mHeader + ".TestPointwiseProduct\n";
				string output = header;
				Vector3 one = new Vector3(2.0f, 4.0f, 6.0f);
				Vector3 two = new Vector3(3.0f, 5.0f, 7.0f);
				Vector3 result = Vector3.zero;

				result = Vectors.PointwiseProduct(one, two);
				if (result.x != 6.0f || result.y != 20.0f || result.z != 42.0f)
					output += "#1 FAILED: " + result.ToString("F3") + "\n";
				result = Vector3.zero;

				result = Vectors.PointwiseProduct(one, two.x, two.y, two.z);
				if (result.x != 6.0f || result.y != 20.0f || result.z != 42.0f)
					output += "#2 FAILED: " + result.ToString("F3") + "\n";
				result = Vector3.zero;

				OutputResults(output, header);
			}
		}

		private class Vector4Tests {
			private string mHeader = "Vector4Tests";

			public void Go() {
				TestPointwiseProduct();
			}

			private void TestPointwiseProduct() {
				string header = mHeader + ".TestPointwiseProduct\n";
				string output = header;
				Vector4 one = new Vector4(2.0f, 4.0f, 6.0f, 8.0f);
				Vector4 two = new Vector4(3.0f, 5.0f, 7.0f, 9.0f);
				Vector4 result = Vector4.zero;

				result = Vectors.PointwiseProduct(one, two);
				if (result.x != 6.0f || result.y != 20.0f || result.z != 42.0f || result.w != 72.0f)
					output += "#1 FAILED: " + result.ToString("F3") + "\n";
				result = Vector4.zero;

				result = Vectors.PointwiseProduct(one, two.x, two.y, two.z, two.w);
				if (result.x != 6.0f || result.y != 20.0f || result.z != 42.0f || result.w != 72.0f)
					output += "#2 FAILED: " + result.ToString("F3") + "\n";
				result = Vector4.zero;

				OutputResults(output, header);
			}
		}

		public static void OutputResults(string result, string original) {
			if (result.Equals(original)) {
				Debug.Log(result + "GO!");
			} else {
				Debug.LogError(result);
			}
		}
	}
}