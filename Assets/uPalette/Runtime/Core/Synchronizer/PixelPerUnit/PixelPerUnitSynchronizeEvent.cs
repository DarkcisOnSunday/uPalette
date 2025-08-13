using UnityEngine;
using uPalette.Runtime.Core.Model;

namespace uPalette.Runtime.Core.Synchronizer.PixelPerUnit
{
    public sealed class PixelPerUnitSynchronizeEvent : ValueSynchronizeEvent<float>
    {
        [SerializeField] private GradientEntryId _entryId = new GradientEntryId();

        public override EntryId EntryId => _entryId;

        public override Palette<float> GetPalette(PaletteStore store)
        {
            return store.FloatPalette;
        }
    }
}
