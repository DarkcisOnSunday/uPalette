using System;
using UnityEditor.IMGUI.Controls;
using uPalette.Runtime.Foundation.CharacterStyles;

namespace uPalette.Editor.Core.PaletteEditor
{
    [Serializable]
    internal sealed class PixelPerUnitPaletteEditorWindowContentsView : PaletteEditorWindowContentsView<float>
    {
        protected override PaletteEditorTreeView<float> CreateTreeView(TreeViewState state)
        {
            return new PixelPerUnitPaletteEditorTreeView(state);
        }
    }
}
