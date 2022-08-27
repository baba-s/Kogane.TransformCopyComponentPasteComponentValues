﻿using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace Kogane.Internal
{
    internal static class TransformCopyComponentPasteComponentValues
    {
        [MenuItem( "CONTEXT/Transform/Copy Component" )]
        public static void CopyComponent( MenuCommand menuCommand )
        {
            var transform = ( Transform )menuCommand.context;
            ComponentUtility.CopyComponent( transform );
        }

        [MenuItem( "CONTEXT/Transform/Paste Component Values" )]
        public static void PasteComponentValues( MenuCommand menuCommand )
        {
            var transform = ( Transform )menuCommand.context;
            ComponentUtility.PasteComponentValues( transform );
        }
    }
}