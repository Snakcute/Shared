using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snakcute.Shared
{
    public enum UserRelationStatus
    {
        Request, //发送好友请求
        Pending, //需审核接受
        Friend //好友关系
    }
}
