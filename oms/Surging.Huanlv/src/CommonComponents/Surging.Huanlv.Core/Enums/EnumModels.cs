using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Surging.Huanlv.Core.Enums
{
    [EnumAsInt]
    public enum UserStatus
    {
        全部 = 0,
        正常 = 1,
        锁定 = 2,
    }
}
