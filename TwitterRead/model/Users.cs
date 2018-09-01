using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TwitterRead.model
{
    [DataContract]
    class Users
    {
        [DataMember(Name = "user_names")]
        public List<String> UserNames { get; set; }
    }
}