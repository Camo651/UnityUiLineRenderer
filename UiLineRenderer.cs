using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[ExecuteAlways]
///<summary>
/// Draws a UI line between 2 points
/// </summary>
public class UiLineRenderer : MonoBehaviour
{
	public RectTransform rt;
	public Vector2 pos1, pos2;
	public float lineWidth;
	public void Update()
	{
		UpdateLine();
	}

	public void UpdateLine()
	{
		if (!rt)
			rt = GetComponent<RectTransform>();
		rt.sizeDelta = new Vector2(Vector2.Distance(pos1, pos2), lineWidth);
		rt.anchoredPosition = Vector2.Lerp(pos1, pos2, .5f);
		if(pos2.x - pos1.x != 0)
			rt.localEulerAngles = Vector3.forward * Mathf.Rad2Deg * Mathf.Atan((pos2.y - pos1.y) / (pos2.x - pos1.x));

	}
}
