using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PokemonBase))]
public class PokemonBaseEditor : Editor
{
    public override void OnInspectorGUI()
    {
        PokemonBase pokemonBase = (PokemonBase)target;

        EditorGUI.BeginChangeCheck();

        // Display the default Inspector GUI for the ScriptableObject.
        DrawDefaultInspector();

        // Check if the name has been changed.
        if (GUILayout.Button("Set pokemonName from Asset Name"))
        {
            // Get the name of the asset.
            string assetName = AssetDatabase.GetAssetPath(pokemonBase);
            assetName = System.IO.Path.GetFileNameWithoutExtension(assetName);

            // Set the pokemonName field.
            pokemonBase.PokemonName = assetName;

            // Mark the ScriptableObject as dirty so that changes are saved.
            EditorUtility.SetDirty(pokemonBase);
        }
    }
}





