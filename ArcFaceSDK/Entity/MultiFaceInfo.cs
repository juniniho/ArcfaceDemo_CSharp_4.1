using ArcFaceSDK.SDKModels;

namespace ArcFaceSDK.Entity
{
    /// <summary>
    /// 多人脸检测
    /// </summary>
    public class MultiFaceInfo
    {
        /// <summary>
        /// 人脸Rect结果集
        /// </summary>
        public MRECT[] faceRects { get; set; }

        /// <summary>
        /// 人脸角度结果集，与faceRects一一对应  对应ASF_OrientCode
        /// </summary>
        public int[] faceOrients { get; set; }

        /// <summary>
        /// 结果集大小
        /// </summary>
        public int faceNum { get; set; }

        /// <summary>
        /// face ID，IMAGE模式下不返回FaceID
        /// </summary>
        public int[] faceID { get; set; }

        /// <summary>
        /// 多张人脸信息
        /// </summary>
        public FaceDataInfo[] faceDataInfoList { get; set; }

        /// <summary>
        /// 人脸是否在边界内 0 人脸溢出；1 人脸在图像边界内
        /// </summary>
        public int[] faceIsWithinBoundary { get;set; }

        /// <summary>
        /// 人脸额头区域
        /// </summary>
        public MRECT[] foreheadRect { get; set; }

        /// <summary>
        /// 人脸属性信息
        /// </summary>
        public FaceAttributeInfo faceAttributeInfo { get; set; }

        /// <summary>
        /// 人脸3D角度
        /// </summary>
        public Face3DAngle face3DAngleInfo { get; set; }
    }
}
