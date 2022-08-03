# ArcfaceDemo_CSharp_4.1
基于https://github.com/SkyStonePan/ArcfaceDemo_CSharp_4.0 升级而来

非托管内存的注意事项
1. struct的定义必须和c++的定义顺序一致，否则会出现内存引用错误。
2. struct直接嵌套，不能定义为IntPtr
