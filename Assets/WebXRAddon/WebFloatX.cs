using Zinnia.Action;
using WebXR;
using Unity;
public class WebFloatX : FloatAction
{
 public WebXRController controller;
 private float xAxis;
 void Update()
 {
 var vector2 = controller.GetAxis2D(WebXRController.Axis2DTypes.Thumbstick);
 xAxis = vector2.x;
 Receive(xAxis); 
 }
}
