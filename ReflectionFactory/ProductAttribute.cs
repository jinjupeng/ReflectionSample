using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionFactory
{
    /// <summary>
    /// 屋子产品的零件
    /// </summary>
    public enum RoomParts
    {
        Roof,
        Window,
        Pillar
    }
    /// <summary>
    /// 这个特性用来附加在产品类型之上，
    /// 来标注该类型代码哪个产品，方便反射使用
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ProductAttribute : Attribute
    {
        //标注零件的成员
        private RoomParts _myRoomPart;

        public ProductAttribute(RoomParts part)
        {
            _myRoomPart = part;
        }
        public RoomParts RoomPart
        {
            get
            {
                return _myRoomPart;
            }
        }
    }
    /// <summary>
    /// 这个特性用来附加在产品接口之上
    /// 来标注一共实现了多少产品零件，方便反射使用
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    public class ProductListAttribute : Attribute
    {
        private Type[] _myList;

        public ProductListAttribute(Type[] Products)
        {
            _myList = Products;
        }
        public Type[] ProductList
        {
            get
            {
                return _myList;
            }
        }
    }

    #region 产品类族
    /// <summary>
    /// 产品零件接口，
    /// 需要添加所有实现该接口的列表
    /// </summary>
    [ProductList(new Type[]{
                typeof(Roof),
                typeof(Window),
                typeof(Pillar)})]
    public interface IProduct
    {
        String GetName();
    }
    /// <summary>
    /// 屋顶类型
    /// </summary>
    [ProductAttribute(RoomParts.Roof)]
    public class Roof : IProduct
    {
        public String GetName()
        {
            return "屋顶";
        }
    }
    /// <summary>
    /// 窗户类型
    /// </summary>
    [Product(RoomParts.Window)]
    public class Window : IProduct
    {
        public String GetName()
        {
            return "窗户";
        }
    }
    /// <summary>
    /// 柱子类型
    /// </summary>
    [ProductAttribute(RoomParts.Pillar)]
    public class Pillar : IProduct
    {
        public String GetName()
        {
            return "柱子";
        }
    }
    #endregion
}
