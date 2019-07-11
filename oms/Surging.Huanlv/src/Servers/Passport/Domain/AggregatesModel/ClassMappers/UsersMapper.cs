using DapperExtensions.Mapper;
using Huanlv.Passport.Domain.AggregatesModel.UserAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huanlv.Passport.Domain.AggregatesModel.ClassMappers
{
    public class UsersMapper : ClassMapper<UserInfo>
    {
        public UsersMapper()
        {
            Table("Users");
            AutoMap();
        }
    }
}
