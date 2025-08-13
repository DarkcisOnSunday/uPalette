using System;

namespace uPalette.Runtime.Core.Synchronizer.PixelPerUnit
{
    public sealed class PixelPerUnitSynchronizerAttribute : ValueSynchronizerAttribute
    {
        public PixelPerUnitSynchronizerAttribute(Type attachTargetType, string targetPropertyDisplayName)
            : base(typeof(float), attachTargetType, targetPropertyDisplayName)
        {
        }
    }
}
