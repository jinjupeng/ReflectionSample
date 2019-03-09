using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionFactory
{
    /// <summary>
    /// 工厂管理类型
    /// </summary>
    public class FactoryManager
    {
        public static IProduct GetProduct(RoomParts part)
        {
            Factory factory = new Factory();
            IProduct product = factory.Produce(part);
            Console.WriteLine("生产了一个产品：" +
                product.GetName());
            return product;
        }
    }
}
