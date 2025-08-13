using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace uPalette.Editor.Core.PaletteEditor
{
    internal sealed class PixelPerUnitPaletteEditorTreeView : PaletteEditorTreeView<float>
    {
        public PixelPerUnitPaletteEditorTreeView(TreeViewState state) : base(state)
        {
        }

        protected override float DrawValueField(Rect rect, float value)
        {
            return EditorGUI.FloatField(rect, value);
        }
    }
}
