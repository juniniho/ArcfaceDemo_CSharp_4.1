using System;

namespace ArcFaceSDK.SDKModels
{
    /// <summary>
    /// 多人脸检测结构体
    /// </summary>
    public struct ASF_MultiFaceInfo
    {
        /// <summary>
        /// 结果集大小
        /// </summary>
        public int faceNum;

        /// <summary>
        /// 人脸Rect结果集
        /// </summary>
        public IntPtr faceRect;

        /// <summary>
        /// 人脸角度结果集，与faceRect一一对应  对应ASF_OrientCode
        /// </summary>
        public IntPtr faceOrient;

        /// <summary>
        /// face ID，IMAGE模式下不返回FaceID
        /// </summary>
        public IntPtr faceID;

        /// <summary>
        /// 多张人脸信息
        /// </summary>
        public IntPtr faceDataInfoList;

        /// <summary>
        /// 人脸是否在边界内 0 人脸溢出；1 人脸在图像边界内
        /// </summary>
        public IntPtr faceIsWithinBoundary;

        /// <summary>
        /// 人脸额头区域
        /// </summary>
        public IntPtr foreheadRect;

        /// <summary>
        /// 人脸属性信息
        /// </summary>
        public ASF_FaceAttributeInfo faceAttributeInfo;

        /// <summary>
        /// 人脸3D角度
        /// </summary>
        public ASF_Face3DAngle face3DAngleInfo;
    }
}
