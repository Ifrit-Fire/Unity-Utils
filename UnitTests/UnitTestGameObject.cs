using System;
using UnityEngine;

namespace Sawyer.Utils.UnitTest {
	public class UnitTestGameObject : MonoBehaviour {
		public GameObject prefab;
		public GameObject sceneGameObject;
		private GameObject mNull;

		private string mHeader = "GameObjectTests";

		void Start() {
			string result = mHeader;
			int oldInstance = sceneGameObject.GetInstanceID();
			sceneGameObject.Instantiate();
			if (oldInstance != sceneGameObject.GetInstanceID()) {
				result += ".sceneGameObject: Different instance ID\n";
			}

			prefab.Instantiate();
			if (prefab.activeInHierarchy) {
				result += ".prefabGameObject: Not detected\n";
			}

			bool coughtError = false;
			try {
				GameObjects.Instantiate(mNull);
			} catch (NullReferenceException e) {
				coughtError = true;
			}
			if (!coughtError) {
				result += ".nullPrefab: Is required to throw error\n";
			}

			if (result.Equals(mHeader)) {
				Debug.Log(mHeader + "\nGO!");
			} else {
				Debug.LogError(result);
			}
		}
	}
}
