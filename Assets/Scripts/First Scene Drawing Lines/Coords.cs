using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Draw {
	public class Coords
	{
		float x, y, z;

		public Coords(float _X, float _Y)
		{
			x = _X;
			y = _Y;
			z = -1;
		}

		public override string ToString()
		{
			return "(" + x + "," + y + "," + z + ")";
		}

		//draw line in 2d
		static public void DrawPoint(Coords position, float width, Color colour)
		{
			GameObject line = new GameObject("Point_" + position.ToString());
			LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
			lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
			lineRenderer.material.color = colour;
			lineRenderer.positionCount = 2;
			lineRenderer.SetPosition(0, new Vector3(position.x - width / 3.0f, position.y - width / 3.0f, position.z));
			lineRenderer.SetPosition(1, new Vector3(position.x + width / 3.0f, position.y + width / 3.0f, position.z));
			lineRenderer.startWidth = width;
			lineRenderer.endWidth = width;

		}

		static public void DrawLine(Coords _strartPosition, Coords _endPosition, float width, Color colour)
		{
			GameObject line = new GameObject("Line_" + _strartPosition.ToString() + "_" + _endPosition.ToString());

			LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
			lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
			lineRenderer.material.color = colour;
			lineRenderer.positionCount = 2;
			lineRenderer.SetPosition(0, new Vector3(_strartPosition.x, _strartPosition.y, _strartPosition.z));
			lineRenderer.SetPosition(1, new Vector3(_endPosition.x, _endPosition.y, _endPosition.z));
			lineRenderer.startWidth = width;
			lineRenderer.endWidth = width;
		}
	}
}
	

