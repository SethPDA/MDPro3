using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class NewText : Text
    {
        //实现超框时再缩小字体
        public int Visiblelines { get; private set; }
        private void _UseFitSettings()
        {
            TextGenerationSettings settings = GetGenerationSettings(rectTransform.rect.size);
            settings.resizeTextForBestFit = false;

            if (!resizeTextForBestFit)
            {
                cachedTextGenerator.PopulateWithErrors(text, settings, gameObject);
                return;
            }

            int minSize = resizeTextMinSize;
            int txtLen = text.Length;
            for (int i = resizeTextMaxSize; i >= minSize; i--)
            {
                settings.fontSize = i;
                cachedTextGenerator.PopulateWithErrors(text, settings, gameObject);
                if (cachedTextGenerator.characterCountVisible == txtLen)
                    break;
            }
        }

        private readonly UIVertex[] _tmpVerts = new UIVertex[4];
        protected override void OnPopulateMesh(VertexHelper toFill)
        {
            if (font == null)
                return;

            m_DisableFontTextureRebuiltCallback = true;
            _UseFitSettings();

            //Apply the offset to the verticles
            IList<UIVertex> verts = cachedTextGenerator.verts;
            float unitPerPixel = 1 / pixelsPerUnit;
            int vertCount = verts.Count;

            if (vertCount <= 0)
            {
                toFill.Clear();
                return;
            }

            Vector2 roundingOffset = new Vector2(verts[0].position.x, verts[0].position.y) * unitPerPixel;
            roundingOffset = PixelAdjustPoint(roundingOffset) - roundingOffset;
            toFill.Clear();
            if (roundingOffset != Vector2.zero)
            {
                for (int i = 0; i < vertCount; i++)
                {
                    int tempVertsIndex = i & 3;
                    _tmpVerts[tempVertsIndex] = verts[i];
                    _tmpVerts[tempVertsIndex].position *= unitPerPixel;
                    _tmpVerts[tempVertsIndex].position.x += roundingOffset.x;
                    _tmpVerts[tempVertsIndex].position.y += roundingOffset.y;
                    if (tempVertsIndex == 3)
                        toFill.AddUIVertexQuad(_tmpVerts);
                }
            }
            else
            {
                for (int i = 0; i < vertCount; i++)
                {
                    int tempVertsIndex = i & 3;
                    _tmpVerts[tempVertsIndex] = verts[i];
                    _tmpVerts[tempVertsIndex].position *= unitPerPixel;
                    if (tempVertsIndex == 3)
                        toFill.AddUIVertexQuad(_tmpVerts);
                }
            }
            m_DisableFontTextureRebuiltCallback = false;
            Visiblelines = cachedTextGenerator.lineCount;
        }
    }
}
