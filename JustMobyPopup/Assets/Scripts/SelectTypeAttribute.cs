using System;
using UnityEngine;

namespace Game.Popups
{
    public sealed class SelectTypeAttribute : PropertyAttribute
    {
        public Type DefaultType { get; set; }
        public SelectTypeAttribute(Type defaultType = null) : base()
        {
            DefaultType = defaultType;
        }
    }
}
