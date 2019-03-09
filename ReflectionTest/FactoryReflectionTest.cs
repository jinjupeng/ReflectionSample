using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionFactory;

namespace ReflectionTest
{
    /// <summary>
    /// 使用者
    /// </summary>
    [TestClass]
    public class FactoryReflectionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //使用者的代码和传统实现一样
            IProduct window = ReflectionFactory.FactoryManager.GetProduct(RoomParts.Window);
            IProduct pillar = ReflectionFactory.FactoryManager.GetProduct(RoomParts.Pillar);
            IProduct roof = ReflectionFactory.FactoryManager.GetProduct(RoomParts.Roof);
        }
    }
}
