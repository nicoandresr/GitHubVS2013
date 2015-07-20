using System;
using System.Collections.Generic;
using System.Linq;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.Filter;

namespace serfid.Filter
{
    public class FilterPrototipeProtocol : IFilter
    {
        #region Attributes

        private int validLength = 26;

        #endregion

        #region Constructor

        #endregion

        #region Public methods

        public ModuleStatus Start()
        {
            Console.WriteLine("Filter started!");
            return ModuleStatus.success;
        }

        public FilterResult Tramit(string weft)
        {
            FilterResult result = this.ValidateWeft(weft);
            return result;
        }

        #endregion

        #region Prvate methods

        private FilterResult ValidateWeft(string weft)
        {
            if (this.IsInvalidLength(weft))
                return FilterResult.Discard;

            if (IsInvalidStructure(weft))
                return FilterResult.Discard;

            return FilterResult.Acepted;
        }

        private static bool IsInvalidStructure(string weft)
        {
            bool invalid = true;
            List<string> data = GetData(weft);
            foreach (string field in data)
            {
                invalid = IsNotHexField(field);
                if (invalid) break;
            }

            return invalid;
        }

        private static bool IsNotHexField(IEnumerable<char> chars)
        {
            foreach (char c in chars)
            {
                bool isHex = ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F'));

                if (!isHex)
                    return true;
            }

            return false;
        }

        private static List<string> GetData(string weft)
        {
            NormalizeWeft(ref weft);
            return new List<string>
            {
                GetHeader(weft),
                GetCompany(weft),
                GetRef(weft),
                GetSubject(weft),
                GetPassword(weft)
            };
        }

        private static void NormalizeWeft(ref string weft)
        {
            weft = weft.Trim().ToUpper();
        }

        private static string GetHeader(string weft)
        {
            return weft.Substring(0, 2);
        }

        private static string GetCompany(string weft)
        {
            return weft.Substring(2, 6);
        }

        private static string GetRef(string weft)
        {
            return weft.Substring(8, 2);
        }

        private static string GetSubject(string weft)
        {
            return weft.Substring(10, 6);
        }

        private static string GetPassword(string weft)
        {
            return weft.Substring(16, 10);
        }

        private bool IsInvalidLength(string weft)
        {
            return weft.Length != validLength;
        }

        #endregion
    }
}
