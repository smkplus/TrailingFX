using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureMe : MonoBehaviour {
	public RenderTexture RT;
	public Camera camera;

	void Update(){
	}

	void OnRenderImage(RenderTexture source,RenderTexture target){
		RenderTexture texture = new RenderTexture(Screen.width , Screen.height, 16, RenderTextureFormat.ARGB32);

		int resWidth = Screen.width;
		int resHeight = Screen.height;

		RT = new RenderTexture(resWidth, resHeight, 24);
		camera.targetTexture = RT; //Create new renderTexture and assign to camera
		Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false); //Create new texture

		camera.Render();

		RenderTexture.active = RT;
		screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0); //Apply pixels from camera onto Texture2D

		camera.targetTexture = null;
		RenderTexture.active = null; //Clean


		Graphics.Blit (RT, target);

		Destroy(RT); //Free memory



	}
}
