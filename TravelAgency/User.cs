//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelAgency
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int id_user { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string login { get; set; }
        public int password { get; set; }
        public int id_gender { get; set; }
        public System.DateTime birthday { get; set; }
        public int id_role { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Role Role { get; set; }
    }
}
