using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMaker.Model.Enum
{
    /// <summary>
    /// 生成方法
    /// </summary>
    public enum BuilderMethods
    {
        /// <summary>
        /// 增加
        /// </summary>
        Add,

        /// <summary>
        /// 修改
        /// </summary>
        Update,

        /// <summary>
        /// 删除
        /// </summary>
        Delete,

        /// <summary>
        /// 查询所有记录
        /// </summary>
        SelectAll,

        /// <summary>
        /// 查询主键记录
        /// </summary>
        SelectByKey,

        /// <summary>
        /// 判断记录是否存在
        /// </summary>
        Exists,

        /// <summary>
        /// 查询记录总数
        /// </summary>
        Count
    }
}
