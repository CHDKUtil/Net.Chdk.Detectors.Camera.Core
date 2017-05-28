using Net.Chdk.Model.Camera;
using Net.Chdk.Model.Card;
using Net.Chdk.Model.Software;

namespace Net.Chdk.Detectors.Camera
{
    public interface ICameraDetector
    {
        CameraInfo GetCamera(CardInfo cardInfo, SoftwareInfo softwareInfo);
    }
}