Shader "Custom/FinalOutline"
{
	Properties//Variables
	{
		_MainTex("Main Texture (RBG)", 2D) = "white" {}//Allows for a texture property.
		_Color("ColorObject", Color) = (1,1,1,1)//Allows for a color property.

		_OutlineWidth("Outline Width", Range(1.0,10.0)) = 1.1


		_DistortColor("Outline Color", Color) = (1,1,1,1)
		
		_DistortTex("Distort Texture (RGB)", 2D) = "white" {}
		_BumpAmt("Distortion", Range(0,128)) = 10
		
	}

	SubShader
	{
		Tags
		{
			"Queue" = "Transparent"
		}

		GrabPass{}//Grabs everything behind the object.
		UsePass "Custom/OutlineDistort/OUTLINEDISTORT"//Distorts everything behind the object plus the outline width.
		GrabPass{}//Grabs the distorted pass.
	
		UsePass "Custom/Outline/OBJECT"//Renders the object.
	}
	
}
