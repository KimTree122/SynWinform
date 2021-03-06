﻿using CS.DAL;
using KNDBsys.Model.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL.BaseInfo
{
    public class ServerTypeService:PostService<ServerType,ServerType>
    {
        public List<ServerType> GetAllServerTypes(int userid)
        {
            string url = KNDBsysUrl.BaseInfoUrl.ServerTypeUrl.GetAllServerType;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid).Build(); ;
            return GetList(url, tools);
        }

        public int AddServerType(ServerType serverType)
        {
            string url = KNDBsysUrl.BaseInfoUrl.ServerTypeUrl.AddServerType;
            HttpTools tools = new HttpTools();
            tools.AddParam("servertype", DataSwitch.DataToJson(serverType)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt();
        }

        public bool UpdateServerType(ServerType serverType)
        {
            string url = KNDBsysUrl.BaseInfoUrl.ServerTypeUrl.UpdatServerType;
            HttpTools tools = new HttpTools();
            tools.AddParam("servertype", DataSwitch.DataToJson(serverType)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

        public bool DeleteServerType(ServerType serverType)
        {
            string url = KNDBsysUrl.BaseInfoUrl.ServerTypeUrl.DeleteServerType;
            HttpTools tools = new HttpTools();
            tools.AddParam("servertype", DataSwitch.DataToJson(serverType)).Build();
            string msg = GetMsg(url, tools);
            return msg.ToInt() > 0;
        }

    }
}
