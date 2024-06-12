using UnityEditor;
using UnityEngine;

namespace GOL.Landscape
{
    [CustomEditor(typeof(WorldBootstrap))]
    class BootstrapEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            WorldBootstrap bootstrap = (WorldBootstrap)target;
            if (GUILayout.Button("Rebuild World View"))
            {
                bootstrap.ResetWorld(true);
            }
            if (GUILayout.Button("Repair World View"))
            {
                bootstrap.DestroyWorld();
            }
        }
    }
}