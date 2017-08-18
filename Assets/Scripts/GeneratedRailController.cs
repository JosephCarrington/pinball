using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedRailController : MonoBehaviour {

	// Use this for initialization
	LineRenderer line;
	EdgeCollider2D edge;
	[ExecuteInEditMode]
	void Start () {
		line = gameObject.GetComponent<LineRenderer> ();
		edge = gameObject.GetComponent<EdgeCollider2D> ();
		line.positionCount = edge.pointCount;
		Vector3[] points = new Vector3[edge.pointCount];
		int x = 0;
		foreach (Vector2 point in edge.points) {
			points [x] = new Vector3 (point.x, point.y, 0);
			x++;
		}
		line.SetPositions (points);
	}

	void OnDrawGizmosSelected() {
		line = gameObject.GetComponent<LineRenderer> ();
		edge = gameObject.GetComponent<EdgeCollider2D> ();
		line.positionCount = edge.pointCount;
		Vector3[] points = new Vector3[edge.pointCount];
		int x = 0;
		foreach (Vector2 point in edge.points) {
			points [x] = new Vector3 (point.x, point.y, 0);
			x++;
		}
		line.SetPositions (points);
	}
}
