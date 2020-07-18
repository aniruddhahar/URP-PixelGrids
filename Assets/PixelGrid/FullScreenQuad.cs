// This script was originally shared by Felipe Lira from Unity Technologies
// https://gist.github.com/phi-lira/46c98fc67640cda47dcd27e9b3765b85

namespace UnityEngine.Rendering.Universal
{
    // A renderer feature contains data and logic to enqueue one or more render passes in the LWRP renderer.
    // In order to add a render feature to a LWRP renderer, click on the renderer asset and then on the + icon in 
    // the renderer features list. LWRP uses reflection to list all renderer features in the project as available to be 
    // added as renderer features.
    public class FullScreenQuad : UnityEngine.Rendering.Universal.ScriptableRendererFeature
    {
        [System.Serializable]
        public struct FullScreenQuadSettings
        {
            // The render pass event to inject this render feature.
            public UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent;

            // Material to render the quad. 
            public Material material;
        }

        // Contains settings for the render pass.
        public FullScreenQuadSettings m_Settings;

        // The actual render pass we are injecting.
        FullScreenQuadPass m_RenderQuadPass;

        public override void Create()
        {
            // Caches the render pass. Create method is called when the renderer instance is being constructed. 
            m_RenderQuadPass = new FullScreenQuadPass(m_Settings);
        }

        public override void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData)
        {
            // Enqueues the render pass for execution. Here you can inject one or more render passes in the renderer
            // AddRenderPasses is called everyframe. 
            if (m_Settings.material != null)
                renderer.EnqueuePass(m_RenderQuadPass);
        }
    }
}
