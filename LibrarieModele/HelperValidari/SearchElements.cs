

namespace LibrarieModele
{
    public struct SearchElement
    {
        private string columnName;
        private string value;

        public string ColumnName { get { return columnName; } }
        public string Value { get { return value; } }

        /// <summary>
        /// Struct pentru a prelua coloana si valoarea din -datagridview- pentru search
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="value"></param>
        public SearchElement(string columnName, string value)
        {
            this.columnName = columnName;
            this.value = value;
        }

        public override string ToString()
        {
            return $"{columnName} {value}";
        }
    }
}
