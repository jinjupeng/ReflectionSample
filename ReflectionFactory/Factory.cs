using System;
using System.Reflection;


namespace ReflectionFactory
{
    #region 工厂类
    /// <summary>
    /// 工厂类型，这里不再需要一个类族，
    /// 而只需要一个工厂类型
    /// </summary>
    public class Factory
    {
        public IProduct Produce(RoomParts part)
        {
            //通过反射，从IProduct 接口中获得属性,
            //从而获得所有的产品零件列表
            ProductListAttribute Attr = (ProductListAttribute)
                    Attribute.GetCustomAttribute(typeof(IProduct),
                            typeof(ProductListAttribute));

            //遍历所有的实现产品零件类型
            foreach (Type type in Attr.ProductList)
            {
                //利用反射查找其属性
                ProductAttribute pa = (ProductAttribute)
                                    Attribute.GetCustomAttribute(
                                    type, typeof(ProductAttribute));
                //确定是否是需要的零件
                if (pa.RoomPart == part)
                {
                    //再一次利用反射
                    //创建产品零件类型
                    Object product = Assembly.GetExecutingAssembly().
                        CreateInstance(type.FullName);
                    return product as IProduct;
                }
            }
            //不应该到达这里
            return null;
        }
    }
    #endregion
}
