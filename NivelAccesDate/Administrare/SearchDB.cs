using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using LibrarieModele;

namespace NivelAccesDate
{
    public static class SearchDB<T>
    {
        private const int PRIMUL_TABEL = 0;

        public static List<T> GetSpecificElements(List<SearchElement> searchElements, string tableName)
        {
            var result = new List<T>();
            StringBuilder conditions = new StringBuilder();

            foreach (var item in searchElements)
            {
                int number;
                if (Int32.TryParse(item.Value, out number))
                    conditions.Append($"{item.ColumnName} = {number} AND ");
                else
                    conditions.Append($"UPPER({item.ColumnName}) LIKE '%{item.Value.ToUpper()}%' AND ");
            }

            conditions = conditions.Remove(conditions.Length - 4, 3);
            var ds = SqlDBHelper.ExecuteDataSet($"SELECT * FROM {tableName} WHERE {conditions}", CommandType.Text);

            foreach (DataRow linieDB in ds.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add((T)Activator.CreateInstance(typeof(T), new object[] {linieDB}));
            } 
            return result;
        }

    }
}
