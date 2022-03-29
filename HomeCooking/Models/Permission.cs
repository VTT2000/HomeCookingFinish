using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class Permission
    {
        public Permission()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public string IdPermission { get; set; }
        public string Ten { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
