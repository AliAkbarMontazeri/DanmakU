﻿using UnityEngine;
using UnityEditor;

/// <summary>
/// Custom editor scripts for various components of the Danmaku2D development kit
/// </summary>
namespace Danmaku2D.Editor {

	/// <summary>
	/// Custom <a href="http://docs.unity3d.com/ScriptReference/Editor.html">Editor</a> for ProjectileManager
	/// </summary>
	[CustomEditor(typeof(ProjectileManager))]
	internal class ProjectileManagerEditor : UnityEditor.Editor {

		/// <summary>
		/// Creates custom GUI useful for statistics/debug on the Scene View
		/// Shows how many active Projectiles and how many
		/// </summary>
		public void OnSceneGUI() {
			ProjectileManager pool = target as ProjectileManager;
			GUISkin skin = GUI.skin;
			Handles.BeginGUI ();
			GUILayout.BeginArea (new Rect(0,0,150,60), skin.box);
			GUILayout.BeginVertical ();
			GUILayout.BeginHorizontal ();
			GUILayout.FlexibleSpace ();
			GUILayout.Label ("Projectile Pool");
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal();
			GUILayout.Label ("Total Count: " + pool.TotalCount);
			GUILayout.Label ("Active Count: " + pool.ActiveCount);
			GUILayout.EndVertical ();
			GUILayout.EndArea ();
			if(GUI.changed)
				EditorUtility.SetDirty(target);
			Handles.EndGUI ();
		}
	}
}