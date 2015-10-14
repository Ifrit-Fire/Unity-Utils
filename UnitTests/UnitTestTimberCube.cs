using UnityEngine;

namespace Sawyer.Utils.UnitTest {
	public class UnitTestTimberCube : MonoBehaviour {

		private GameObject mGameObject;
		private Rigidbody mRigidbody;
		private Collider mCollider;
		private Collision mCollision;
		private Renderer mRenderer;
		private Transform mTransform;

		private bool mHasLoggedCollision;

		void Awake() {
			mHasLoggedCollision = false;
			mRigidbody = GetComponent<Rigidbody>();
			mCollider = GetComponent<Collider>();
			mRenderer = GetComponent<Renderer>();
			mTransform = GetComponent<Transform>();
			mGameObject = gameObject;

			Vector4 vector4 = Vector4.one;
			//vector4.Log();
			Vector3 vector3 = mTransform.localScale;
			vector3.Log();
			Vector2 vector2 = Vector2.right;
			//vector2.Log();
		}

		void Start() {
			mCollider.Log();
			mGameObject.LogCollider();

			mRenderer.Log();
			mGameObject.LogRenderer();

			mTransform.Log();
			mGameObject.LogTransform();
		}

		void OnCollisionEnter(Collision collision) {
			if (mHasLoggedCollision)
				return;

			mHasLoggedCollision = true;
		}
	}
}
