﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoftQuanLyNhaHang.Utils
{
    public static class Extensions
    {
        /// <summary>
        /// Converts datatable to list<T> dynamically
        /// </summary>
        /// <typeparam name="T">Class name</typeparam>
        /// <param name="dataTable">data table to convert</param>
        /// <returns>List<T></returns>
        public static List<T> ToList<T>(this DataTable dataTable) where T : new()
        {
            var dataList = new List<T>();

            //Define what attributes to be read from the class
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            //Read Attribute Names and Types
            var objFieldNames = typeof(T).GetProperties(flags).Cast<PropertyInfo>().
                Select(item => new
                {
                    Name = item.Name.ToLower(),
                    Type = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType
                }).ToList();

            //Read Datatable column names and types
            var dtlFieldNames = dataTable.Columns.Cast<DataColumn>().
                Select(item => new
                {
                    Name = item.ColumnName.ToLower(),
                    Type = item.DataType
                }).ToList();

            foreach (DataRow dataRow in dataTable.AsEnumerable().ToList())
            {
                var classObj = new T();

                foreach (var dtField in dtlFieldNames)
                {
                    PropertyInfo propertyInfos = classObj.GetType().GetProperty(dtField.Name, BindingFlags.SetProperty |
        BindingFlags.IgnoreCase |
        BindingFlags.Public |
        BindingFlags.Instance);

                    var field = objFieldNames.Find(x => x.Name == dtField.Name);

                    if (field != null)
                    {

                        if (propertyInfos.PropertyType == typeof(DateTime))
                        {
                            propertyInfos.SetValue(classObj, convertToDateTime(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(int))
                        {
                            propertyInfos.SetValue(classObj, ConvertToInt(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(long))
                        {
                            propertyInfos.SetValue(classObj, ConvertToLong(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(decimal))
                        {
                            propertyInfos.SetValue(classObj, ConvertToDecimal(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(String))
                        {
                            if (dataRow[dtField.Name].GetType() == typeof(DateTime))
                            {
                                propertyInfos.SetValue(classObj, ConvertToDateString(dataRow[dtField.Name]), null);
                            }
                            else
                            {
                                propertyInfos.SetValue(classObj, ConvertToString(dataRow[dtField.Name]), null);
                            }
                        }
                        else if (propertyInfos.PropertyType == typeof(Guid))
                        {
                            propertyInfos.SetValue(classObj, ConvertToGuid(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(bool) || propertyInfos.PropertyType == typeof(Boolean))
                        {
                            propertyInfos.SetValue(classObj, ConvertToBoolean(dataRow[dtField.Name]), null);
                        }
                        else if (propertyInfos.PropertyType == typeof(double?))
                        {
                            double dbVal = 0;
                            if (double.TryParse(dataRow[dtField.Name].ToString(), out dbVal))
                            {
                                propertyInfos.SetValue(classObj, dbVal, null);
                            }

                        }else if(propertyInfos.PropertyType == typeof(double))
                        {
                            propertyInfos.SetValue(classObj, ConvertToDouble(dataRow[dtField.Name]), null);

                        }
                    }


                }
                dataList.Add(classObj);
            }
            return dataList;
        }


        private static bool ConvertToBoolean(object value)
        {
            if (value == null)
                return false;

            return Convert.ToBoolean(value);
        }
        private static string ConvertToDateString(object date)
        {
            if (date == null)
                return string.Empty;

            return Convert.ToDateTime(date).ToString("yyyy/MM/dd");
        }

        private static string ConvertToString(object value)
        {
            return value.ToString();
        }

        private static Guid ConvertToGuid(object value)
        {
            return new Guid(value.ToString());
        }

        private static int ConvertToInt(object value)
        {
            return Convert.ToInt32(value.ToString());
        }

        private static long ConvertToLong(object value)
        {
            return Convert.ToInt64(value);
        }

        private static decimal ConvertToDecimal(object value)
        {
            return Convert.ToDecimal(value);
        }

        private static double ConvertToDouble(object value)
        {

            return Convert.ToDouble(value);
        }

        private static DateTime convertToDateTime(object date)
        {
            return Convert.ToDateTime(date);
        }

        public static string NonUnicode(this string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
    }
}
