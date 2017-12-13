using UnityEngine;
using System.Collections;

public class MenuButton
{
	protected GameObject vb;
	protected GameObject vbPlane;
	protected GameObject vbLabel;

	public MenuButton(string vbName, string vbPlaneName, string vbLabelName)
	{
		vb = GameObject.Find(vbName);
		vbPlane = GameObject.Find(vbPlaneName);
		vbLabel = GameObject.Find(vbLabelName);

	}



}

