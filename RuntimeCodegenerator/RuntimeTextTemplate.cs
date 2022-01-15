using System.Collections.Generic;

namespace RuntimeCodegenerator
{
    public partial class RuntimeTextTemplate1
    {
        public List<User> UserList = new List<User>();

        public RuntimeTextTemplate1(List<User> userList)
        {
            UserList = userList;
        }
    }
}