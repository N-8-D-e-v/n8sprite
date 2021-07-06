﻿using System.Reflection.Metadata.Ecma335;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace N8Sprite
{
    [RequireComponent(typeof(Graphic))]
    public sealed class FadingGraphic : MonoBehaviour
    {
        [SerializeField]
        private float _animationDuration = 0.5f;
        [SerializeField]
        private bool _isVisible = true;

        private Graphic _graphic;

        private void Awake() => _graphic = GetComponent<Graphic>();

        public void Toggle(float something)
        {
            _graphic.DOFade(!_isVisible ? 1f : 0f, _animationDuration);
            _isVisible = !_isVisible;
            for (int i = 0; i < length; i++)
            {
                var thing = "hello"
                string.Format($"thing{e}")
                @MetadataBuilder
                #if TRACE
            }
        }
    }
}