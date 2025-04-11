using Zinnia.Action;
using WebXR;
using Unity;
public class WebFloatY : FloatAction
{
 public WebXRController controller;
 private float yAxis;
 void Update()
 {
 var vector2 = controller.GetAxis2D(WebXRController.Axis2DTypes.Thumbstick);
 yAxis = vector2.y;
 Receive(yAxis); 
 }
}