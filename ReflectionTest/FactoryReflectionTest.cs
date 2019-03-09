using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionFactory;

namespace ReflectionTest
{
    /// <summary>
    /// ʹ����
    /// </summary>
    [TestClass]
    public class FactoryReflectionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ʹ���ߵĴ���ʹ�ͳʵ��һ��
            IProduct window = ReflectionFactory.FactoryManager.GetProduct(RoomParts.Window);
            IProduct pillar = ReflectionFactory.FactoryManager.GetProduct(RoomParts.Pillar);
            IProduct roof = ReflectionFactory.FactoryManager.GetProduct(RoomParts.Roof);
        }
    }
}
