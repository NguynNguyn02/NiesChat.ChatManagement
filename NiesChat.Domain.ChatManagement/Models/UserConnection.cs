﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiesChat.Domain.ChatManagement.Models;

public class UserConnection
{
    public string UserName { get; set; } = string.Empty;
    public string ChatRoom { get; set; } = string.Empty;
}
