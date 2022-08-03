using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcFaceSDK.SDKModels
{
    public struct ASF_FaceAttributeThreshold
    {
        public float eyeOpenThreshold; // [in] 睁眼幅度阈值，阈值越大睁眼幅度越大
        public float mouthCloseThreshold; // [in] 张嘴幅度阈值，阈值越大，张嘴幅度越小
        public float wearGlassesThreshold;  // [in] 佩戴眼镜阈值
    }
}
