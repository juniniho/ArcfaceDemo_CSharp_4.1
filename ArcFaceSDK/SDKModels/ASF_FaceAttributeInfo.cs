using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcFaceSDK.SDKModels
{
    public struct ASF_FaceAttributeInfo
    {
        public IntPtr wearGlasses;// 戴眼镜状态, 0 未戴眼镜；1 戴眼镜；2 墨镜
        public IntPtr leftEyeOpen;// 左眼状态 0 闭眼；1 睁眼
        public IntPtr rightEyeOpen;// 右眼状态 0 闭眼；1 睁眼
        public IntPtr mouthClose;         // 张嘴状态 0 张嘴；1 合嘴
    }
}
