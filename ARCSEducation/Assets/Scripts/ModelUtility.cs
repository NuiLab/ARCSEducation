using UnityEngine;
using Vuforia;

namespace Utility {
	public class ModelUtility 
	{
		GameObject orModel;
		GameObject andModel;
		GameObject xorModel;
		GameObject notModel;

		GameObject model;

		public ModelUtility( GameObject obj ) {
			/* if (thisModel == "LogicalORModel")
			orModel = obj;
		else if (thisModel == "LogicalANDModel")
			andModel = obj;
		else if (thisModel == "LogicalXORModel")
			xorModel = obj;
		else if (thisModel == "LogicalNOTModel")
			notModel = obj;

		findModels(); */

			model = obj;
		}

		public void findModels(){

			if(orModel != null)
				orModel  = GameObject.Find("LogicalORModel");
			if(andModel != null)
				andModel = GameObject.Find("LogicalANDModel");		
			if (xorModel != null)
				xorModel = GameObject.Find ("LogicalXORModel");
			if (notModel != null)
				notModel = GameObject.Find ("LogicallNotModel");
		}



		public GameObject activateGameObj(GameObject obj){
			obj.SetActive(true);
			return obj;
		}

		public Renderer[] Hidden (bool isHidden) {
			Renderer[] renderers = model.GetComponentsInChildren<Renderer> ();
			foreach (Renderer r in renderers) {
				r.enabled = !isHidden;
			}

			return renderers;
		}
	}
}