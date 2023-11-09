using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MoveBase))]
public class MoveBaseEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MoveBase moveBase = (MoveBase)target;

        EditorGUI.BeginChangeCheck();

        // Display the default Inspector GUI for the ScriptableObject.
        DrawDefaultInspector();

        // Check if the name has been changed.
        if (GUILayout.Button("Set moveName from Asset Name"))
        {
            // Get the name of the asset.
            string assetName = AssetDatabase.GetAssetPath(moveBase);
            assetName = System.IO.Path.GetFileNameWithoutExtension(assetName);

            // Set the pokemonName field.
            moveBase.MoveName = assetName;

            // Mark the ScriptableObject as dirty so that changes are saved.
            EditorUtility.SetDirty(moveBase);
        }
    }
}
