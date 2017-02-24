using WebScadaPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace WebScadaPlatform.Domain
{
    public class Data
    {
        public IEnumerable<Navbar> navbarItems()
        {
            var menu = new List<Navbar>();
            //系统管理
            menu.Add(new Navbar { Id = 1, nameOption = "系统管理", imageClass = "fa fa-cogs fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 101, nameOption = "人员管理", imageClass = "fa fa-user", controller = "Home", action = "Index", status = true, isParent = false, parentId = 1 });
            menu.Add(new Navbar { Id = 102, nameOption = "角色管理", imageClass = "fa fa-group", controller = "Home", action = "Index", status = true, isParent = false, parentId = 1 });
            menu.Add(new Navbar { Id = 103, nameOption = "权限管理", imageClass = "fa fa-key", controller = "Home", action = "Index", status = true, isParent = false, parentId = 1 });
            menu.Add(new Navbar { Id = 104, nameOption = "权限分配", imageClass = "fa fa-check", controller = "Home", action = "Index", status = true, isParent = false, parentId = 1 });
            menu.Add(new Navbar { Id = 105, nameOption = "目录管理", imageClass = "fa fa-sitemap", controller = "Home", action = "Index", status = true, isParent = false, parentId = 1 });

            //运营中心
            menu.Add(new Navbar { Id = 2, nameOption = "运营中心", imageClass = "fa fa-desktop fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 201, nameOption = "全部设备", imageClass = "fa fa-globe", controller = "Home", action = "Index", status = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 202, nameOption = "统计报表", imageClass = "fa fa-bar-chart fa-fw", controller = "Home", action = "Index", status = true, isParent = false, parentId = 2 });

            //饮水安全
            //menu.Add(new Navbar { Id = 3, nameOption = "饮水安全", imageClass = "fa fa-desktop fa-fw", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 301, nameOption = "内黄", imageClass = "fa fa-edit  fa-fw", controller = "Home", action = "Index", status = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 30101, nameOption = "设备分布", imageClass = "fa fa-cloud", controller = "Home", action = "Index", status = true, isParent = false, parentId = 301 });
            menu.Add(new Navbar { Id = 30102, nameOption = "实时数据", imageClass = "fa fa-dashboard", controller = "RealTime", action = "SoilMoisture", status = true, isParent = false, parentId = 301 });
            menu.Add(new Navbar { Id = 30103, nameOption = "统计报表", imageClass = "fa fa-bar-chart-o", controller = "Home", action = "Index", status = true, isParent = false, parentId = 301 });
            menu.Add(new Navbar { Id = 30104, nameOption = "电磁阀控制", imageClass = "fa fa-wrench", controller = "Home", action = "Index", status = true, isParent = false, parentId = 301 });

            //自动灌溉
            menu.Add(new Navbar { Id = 4, nameOption = "自动灌溉", imageClass = "fa fa-desktop fa-fw", status = true, isParent = true, parentId = 0 });

            //灌溉信息化
            menu.Add(new Navbar { Id = 5, nameOption = "灌溉信息化", imageClass = "fa fa-desktop fa-fw", status = true, isParent = true, parentId = 0 });

            //水资源
            menu.Add(new Navbar { Id = 6, nameOption = "水资源", imageClass = "fa fa-desktop fa-fw", status = true, isParent = true, parentId = 0 });





            //menu.Add(new Navbar { Id = 1, nameOption = "Dashboard", controller = "Home", action = "Index", imageClass = "fa fa-dashboard fa-fw", status = true, isParent = false, parentId = 0 });
            //menu.Add(new Navbar { Id = 2, nameOption = "Charts", imageClass = "fa fa-bar-chart-o fa-fw", status = true, isParent = true, parentId = 0 });
            //menu.Add(new Navbar { Id = 3, nameOption = "Flot Charts", controller = "Home", action = "FlotCharts", status = true, isParent = false, parentId = 2 });
            //menu.Add(new Navbar { Id = 4, nameOption = "Morris.js Charts", controller = "Home", action = "MorrisCharts", status = true, isParent = false, parentId = 2 });
            //menu.Add(new Navbar { Id = 5, nameOption = "Tables", controller = "Home", action = "Tables", imageClass = "fa fa-table fa-fw", status = true, isParent = false, parentId = 0 });
            //menu.Add(new Navbar { Id = 6, nameOption = "Forms", controller = "Home", action = "Forms", imageClass = "fa fa-edit fa-fw", status = true, isParent = false, parentId = 0 });
            //menu.Add(new Navbar { Id = 7, nameOption = "UI Elements", imageClass = "fa fa-wrench fa-fw", status = true, isParent = true, parentId = 0 });
            //menu.Add(new Navbar { Id = 8, nameOption = "Panels and Wells", controller = "Home", action = "Panels", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 9, nameOption = "Buttons", controller = "Home", action = "Buttons", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 10, nameOption = "Notifications", controller = "Home", action = "Notifications", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 11, nameOption = "Typography", controller = "Home", action = "Typography", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 12, nameOption = "Icons", controller = "Home", action = "Icons", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 13, nameOption = "Grid", controller = "Home", action = "Grid", status = true, isParent = false, parentId = 7 });
            //menu.Add(new Navbar { Id = 14, nameOption = "Multi-Level Dropdown", imageClass = "fa fa-sitemap fa-fw", status = true, isParent = true, parentId = 0 });
            //menu.Add(new Navbar { Id = 15, nameOption = "Second Level Item", status = true, isParent = false, parentId = 14 });
            //menu.Add(new Navbar { Id = 16, nameOption = "Sample Pages", imageClass = "fa fa-files-o fa-fw", status = true, isParent = true, parentId = 0 });
            //menu.Add(new Navbar { Id = 17, nameOption = "Blank Page", controller = "Home", action = "Blank", status = true, isParent = false, parentId = 16 });
            //menu.Add(new Navbar { Id = 18, nameOption = "Login Page", controller = "Home", action = "Login", status = true, isParent = false, parentId = 16 });

            return menu.ToList();
        }




        public IEnumerable<TagGroupModel> tagGroups()
        {
            var result = new List<TagGroupModel>();
            var group = new TagGroupModel();
            group.Name = "城关镇";
            group.Id = "accordion1";
            group.Tags = new List<TagModel>();

            var tag = new TagModel();
            tag.Extensions = new Hashtable
            {
            { "PanelColor", "green" },
              { "Icon", "svgIcon svg-Pressure" },
            };
            tag.Name = "城关水厂.压力1";
            tag.Id = "value0079";
            tag.Value = "1111";

            group.Tags.Add(tag);


            tag = new TagModel();
            tag.Extensions = new Hashtable
            {
            { "PanelColor", "green" },
              { "Icon", "svgIcon svg-Pressure" },
            };
            tag.Name = "康庄.压力2";
            tag.Id = "value0079";
            tag.Value = "1111";

            group.Tags.Add(tag);

            tag = new TagModel();
            tag.Extensions = new Hashtable
            {
            { "PanelColor", "green" },
              { "Icon", "svgIcon svg-Pressure" },
            };
            tag.Name = "西长固.压力3";
            tag.Id = "value0079";
            tag.Value = "1111";

            group.Tags.Add(tag);

            tag = new TagModel();
            tag.Extensions = new Hashtable
            {
            { "PanelColor", "green" },
              { "Icon", "svgIcon svg-Pressure" },
            };
            tag.Name = "北仗保.压力4";
            tag.Id = "value0079";
            tag.Value = "1111";

            group.Tags.Add(tag);

            tag = new TagModel();
            tag.Extensions = new Hashtable
            { 
            { "PanelColor", "green" },
              { "Icon", "svgIcon svg-Pressure" },
            };
            tag.Name = "南长固.压力5";
            tag.Id = "value0079";
            tag.Value = "1111";

            group.Tags.Add(tag);

            tag = new TagModel();
            tag.Extensions = new Hashtable
            {
                { "PanelColor", "yellow" },
                {"Icon","svgIcon svg-Flow"},
            };
            tag.Name = "瞬时流量1";
            tag.Id = "value0079";
            tag.Value = "1111";

            group.Tags.Add(tag);

            tag = new TagModel();
            tag.Extensions = new Hashtable
            { 
                { "PanelColor", "yellow" },
                {"Icon","svgIcon svg-Flow"},
            };
            tag.Name = "瞬时流量2";
            tag.Id = "value0079";
            tag.Value = "1111";

            group.Tags.Add(tag);

            result.Add(group);
            return result;
        }
    }
}