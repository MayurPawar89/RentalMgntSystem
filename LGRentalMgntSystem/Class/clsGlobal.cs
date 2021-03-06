﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGRentalMgntSystem
{
    public static class clsGlobal
    {
        public static string _sMessageboxCaption = string.Empty;
        public static string MessageboxCaption
        {
            get { return _sMessageboxCaption; }
            //set { _sMessageboxCaption = value; }
        }
        private static string _sName = string.Empty;

        public static string LoginUserName
        {
            get { return clsGlobal._sName; }
            set { clsGlobal._sName = value; }
        }
        private static Int64 _nUserID = 0;

        public static Int64 UserID
        {
            get { return clsGlobal._nUserID; }
            set { clsGlobal._nUserID = value; }
        }
        private static string _sUserDesignation = string.Empty;

        public static string UserDesignation
        {
            get { return clsGlobal._sUserDesignation; }
            set { clsGlobal._sUserDesignation = value; }
        }

        public static string GenerateAbbrivation(string stext)
        {
            string sAbbrivation = string.Empty;
            string[] sFullName = stext.Split(' ');
            foreach (var item in sFullName)
            {
                if (item.All(char.IsDigit))
                {
                    sAbbrivation = sAbbrivation + item.ToString();
                }
                else
                {
                    sAbbrivation = sAbbrivation + item[0].ToString().ToUpper();
                }
            }
            return sAbbrivation;
        }
        
    }
    
}
