using UnityEngine;

namespace Sawyer.Utils.UnitTest {
	public class UnitTestTimberCube : MonoBehaviour {

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

			Vector3 vector3 = mTransform.localScale;
			vector3.Log();
			Timber.LogVector3(vector3);
		}

		void Start() {
			mCollider.Log();
			Timber.LogCollider(mCollider);

			mRenderer.Log();
			Timber.LogRenderer(mRenderer);

			mTransform.Log();
			Timber.LogTransform(mTransform);
		}

		void OnCollisionEnter(Collision collision) {
			if (mHasLoggedCollision)
				return;

			mHasLoggedCollision = true;

		}
	}
}
