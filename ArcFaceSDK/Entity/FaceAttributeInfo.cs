using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcFaceSDK.Entity
{
    public class FaceAttributeInfo
    {
        public int[] wearGlasses;// 戴眼镜状态, 0 未戴眼镜；1 戴眼镜；2 墨镜
        public int[] leftEyeOpen;// 左眼状态 0 闭眼；1 睁眼
        public int[] rightEyeOpen;// 右眼状态 0 闭眼；1 睁眼
        public int[] mouthClose;         // 张嘴状态 0 张嘴；1 合嘴
    }
}
