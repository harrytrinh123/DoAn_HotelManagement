using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace hotel_management
{
    static class ExtensionMethods
    {
        //id Room
        public static bool CheckID(this string id)
        {
            return Regex.Match(id, @"^[rR]\d{1,3}$").Success;
        }
        //id StyleRoom
        public static bool CheckIDStyleRoom(this string id)
        {
            return Regex.Match(id, @"^[a-zA-Z]{1,3}$").Success;
        }
        //Số Room
        public static bool CheckNumbersRoom(this string id)
        {
            return Regex.Match(id, @"^(?!0)\d{1,3}$").Success;
        }
        //Tầng
        public static bool CheckGradeRoom(this string id)
        {
            return Regex.Match(id, @"^\d{1,2}$").Success;
        }
        //Trạng thái phòng
        public static bool CheckStatusRoom(this string id)
        {
            return Regex.Match(id, @"^([Tt][Rr][Uu][Ee]|[Ff][Aa][Ll][Ss][Ee])$").Success;
        }
        //id loại phòng bên Danh Sách Phòng
        public static bool CheckIDStyleRoomLst(this string id)
        {
            return Regex.Match(id, @"^[a-zA-Z]{1,3}$").Success;
        }
        //chk tên StyleRoom
        public static bool CheckNameStyleRoom(this string id)
        {
            // return Regex.Match(id, @"^[Vv][Ii][Pp]|[Tt][Hh][Uu][Oo][Nn][Gg]|[Cc][Aa][Oo][Cc][Aa][Pp]$").Success;
            return Regex.Match(id, @"^[a-zA-Z\s]{1,20}$").Success;
        }
        //Giá
        public static bool CheckPriceStyleRoom(this string id)
        {
            return Regex.Match(id, @"^(?!0)\d*(?:\.\d+)?$").Success;
        }
        //Lưu ý
        public static bool CheckNoteRoom(this string id)
        {
           return Regex.Match(id, @"^[a-zA-Z\s]{1,22}$").Success;
        }

        public static bool CheckName(this string name)
        {
            return Regex.Match(name, @"^[A-Z][a-z]+(\s[A-Z][a-z]+)*$").Success;
        }

        public static bool CheckDate(this DateTime datetime)
        {
            return (datetime.CompareTo(DateTime.Now) <= 0);
        }

        public static bool EmailCheck(this String s)
        {
            return Regex.Match(s, @"^(\w+@\w+([.][a-zA-Z]+){1,4})$").Success;
        }

        public static bool PhoneCheck(this String s)
        {
            return Regex.Match(s, @"^([0][0-9]{2}[1-9]{7})$").Success;
        }
    }
}
