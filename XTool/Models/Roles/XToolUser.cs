﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XTool.Data.ModelInterfaces;
using XTool.Models.TransferModels;

namespace XTool.Models.Roles
{
    public class XToolUser : IdentityUser<int>, IStorageModel<int>
    {

        public IUpdateble Update(IUpdateble model)
        {
            throw new NotImplementedException();
        }

        public string FullName { get; set; }

        public DateTime Birthday { get; set; }

        public string Position { get; set; }

        public bool IsConfirmed { get; set; }

        public bool IsBanned { get; set; }

        public bool WithLogin(LoginModel loginModel)
        {
            return Email == loginModel.Email;
        }
    }
}
