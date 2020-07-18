# URP-PixelGrids
## Procedural shadergraph for simulating pixel grids on LCD/LED/CRT display panels or screens

### This project contains and demonstrates a shadergraph which is used to roughly simulate close-up views of pixel grid geometry on LCD/LED/CRT panels. 
It uses the rounded rectangle node, and some offsets, and supports distortion to some extent. It also supports offsetting the grid for a scanline-like effect. It is meant to be used as a renderer feature in the Universal Render Pipeline Possible applications for this graph are animated Scanline Overlays, or CRT-screen like distortion effects.  It can also be modified to be used for non-fullscreen purposes.

### Demo Video
<a href="http://www.youtube.com/watch?feature=player_embedded&v=oeGGw4PrDuw" target="_blank"><img src="http://img.youtube.com/vi/oeGGw4PrDuw/0.jpg" alt="Oculus Quest Liquids!" width="240" height="180" border="10" /></a>

### Instructions
1. Open the project with Unity (2019.4.3f1 and URP/Shadergraph 7.3.1 or later recommended) and open SampleScene.unity in the Scenes folder
    1. When opening for the first time, ignore any errors about missing renderer features at this point.
2. Make sure the render pipeline is set to URP in Project Settings> Graphics
3. Select the UniversalRenderPipelineAsset and make sure Opaque Texture is enabled.
4. Select the UniversalRenderPipelineAsset_Renderer asset and add a "Full Screen QUad" renderer feature
5. Under the renderer feature settings, assign material the PixelGrid material found in the PixelGrid folder. Alternatively, you can create a new material which uses the PixelGrid Shadergraph
6. Adjust the PixelGrid material properties to get the desired look of the pixel grid:
    1. Number of pixels, size of subpixels
    2. Pixel Brighness, and Custom subpixel colors
    3. Grid and Image Distortion
    4. Overall opacity and Pixel Grid Opacity
7. To use the shadergraph for non-fullscreen/non-screenspace cases, you can simply change the firs screen position node to a UV node, and use a render texture in place of the scene color node.

### Acknowledgements
The full screen quad renderer feature is modified for URP from the following LWRP example provided by Felipe Lira, Lead Graphics Engineer, Unity Technologies:
https://gist.github.com/phi-lira/46c98fc67640cda47dcd27e9b3765b85


