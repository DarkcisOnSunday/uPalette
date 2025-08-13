using UnityEngine;
using uPalette.Runtime.Core.Model;
using uPalette.Runtime.Core.Synchronizer.Gradient;

namespace uPalette.Runtime.Core.Synchronizer.PixelPerUnit
{
    public abstract class PixelPerUnitSynchronizer : ValueSynchronizer<float>
    {
        [SerializeField] private GradientEntryId _entryId = new GradientEntryId();

        public override EntryId EntryId => _entryId;
        
        public override Palette<float> GetPalette(PaletteStore store)
        {
            return store.FloatPalette;
        }
    }

    public abstract class PixelPerUnitSynchronizer<T> : GradientSynchronizer where T : Component
    {
        [SerializeField] [HideInInspector] private T _component;

        protected T Component
        {
            get
            {
                if (_component == null)
                {
                    _component = GetComponent<T>();
                }

                return _component;
            }
        }
    }
}
