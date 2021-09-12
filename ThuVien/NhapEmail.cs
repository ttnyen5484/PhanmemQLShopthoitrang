using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class NhapEmail
    {
        public bool kiemTraEmail(string ChuoiEmail)
        {
            if (ChuoiEmail.Contains("@gmail.com") && ChuoiEmail.Length >= 18)
                return true;
            else
                return false;
        }

    }
}
