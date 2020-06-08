using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DevExpress.Blazor.DocumentMetadata {

    sealed class WebAssemblyMetadataManager : MetadataManagerComponent {
        protected override void BuildRenderTree(RenderTreeBuilder builder) {
            builder.OpenElement(0, "script");
            builder.AddAttribute(1, "type", "text/javascript");
            builder.AddElementReferenceCapture(2, ElementReferenceCaptureAction);
            builder.AddContent(3, @"
                function DxMetadataReady(dotnetRef, elementRef) {
                    var _ = DxMetadataReady;
                    return _[_] || (_[_] = removeElement(elementRef, inject)()); 
                    
                    function inject() {
                        return new Promise(function (resolve, reject) {
                            var el = document.createElement('script');
                            el.onload = wrap(complete);
                            el.onerror = wrap(reject);
                            el.src = '_content/DevExpress.Blazor.DocumentMetadata/dx-head-manager.js';
                            document.head.appendChild(el);

                            function complete() { _dxInitDocumentEnvironment(dotnetRef).then(resolve).catch(reject); }
                            function wrap(f) { return () => removeElement(el, f); }
                        });
                    }
                    function removeElement(el, onRemove) { return el.parentNode.removeChild(el) && onRemove(); }
                }
            ");
            builder.CloseElement();
        }

        private void ElementReferenceCaptureAction(ElementReference obj) {
            ElementReference = obj;
        }

        protected override string JSInitializeMethod => "DxMetadataReady";
    }
}